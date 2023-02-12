using AnInterestingDesktopAppName.Classes;
using AnInterestingWebSiteName.Classes;
using AnInterestingWebSiteName.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnInterestingDesktopAppName
{
    public partial class YoneticiPanel : Form
    {
        BaseClass db = Statics.db;
        Yonetici y = Statics.Yonetici;
        public static Yonetici Yonetici { get; set; }
        public static bool a { get; set; }

        public YoneticiPanel()
        {
            a = true;
            InitializeComponent();
        }

        private void YoneticiPanel_Load(object sender, EventArgs e)
        {
            if (y.YoneticiTur.Yetki < 1)
            {
                MessageBox.Show("Yönetici Panelini Açmak İçin Yeterli Yetkiniz Yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }

            DGV_YoneticiView.AutoGenerateColumns = true;

            IEnumerable<AnInterestingWebSiteName.Models.Yonetici> fvds = db.Yonetici.ToList().AsEnumerable().Where(s => s.Aktifmi == a);

            DGV_YoneticiView.DataSource = fvds.ToList();

            DGV_YoneticiView.Columns["Aktifmi"].Visible = false;
            DGV_YoneticiView.Columns["YoneticiTur"].Visible = false;

            panel1.SendToBack();

        }

        private void btn_ProfilResmi_Click(object sender, EventArgs e)
        {
            Process.Start(db.WebAdress + "/Fotograflar/KullaniciFotograflari/" + y.ProfilFotografi);
        }

        private void btn_Aktif_Click(object sender, EventArgs e)
        {
            if (a)
            {
                btn_Reset_Click(null, null);
                btn_Aktif.Text = "Silinmeyenleri Göster";
                btn_Save.Text = "Geri Getir";
                btn_Sil.Enabled = false;
                a = false;
                btn_Sil.Visible = false;
                tb_Ad.Enabled = false;
                tb_Soyad.Enabled = false;
                tb_KullaniciAdi.Enabled = false;
                tb_Sifre.Enabled = false;
                tb_Mail.Enabled = false;
                cb_Yetki.Enabled = false;
                YoneticiPanel_Load(null, null);
            }
            else
            {
                btn_Reset_Click(null, null);
                btn_Aktif.Text = "Silinenleri Göster";
                btn_Save.Text = "Kaydet";
                btn_Sil.Visible = true;
                btn_Sil.Enabled = true;
                a = true;
                tb_Ad.Enabled = true;
                tb_Soyad.Enabled = true;
                tb_KullaniciAdi.Enabled = true;
                tb_Sifre.Enabled = true;
                tb_Mail.Enabled = true;
                cb_Yetki.Enabled = true;
                YoneticiPanel_Load(null, null);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (a)
            {
                if (Yonetici != null)
                {
                    if (tb_Mail.Text.Contains("@"))
                    {
                        if (tb_Mail.Text.Contains(".com"))
                        {
                            db.Yonetici.First(s => s.ID == Yonetici.ID).YoneticiTur_ID = (int)cb_Yetki.SelectedIndex + 1;
                            db.Yonetici.First(s => s.ID == Yonetici.ID).Isim = tb_Ad.Text;
                            db.Yonetici.First(s => s.ID == Yonetici.ID).SoyIsim = tb_Soyad.Text;
                            db.Yonetici.First(s => s.ID == Yonetici.ID).KullaniciAdi = tb_KullaniciAdi.Text;
                            db.Yonetici.First(s => s.ID == Yonetici.ID).Sifre = tb_Sifre.Text;
                            db.Yonetici.First(s => s.ID == Yonetici.ID).Mail = tb_Mail.Text;
                            YoneticiPanel_Load(null, null);
                            new SerilisationStuff().Save(db);
                        }
                        else
                        {
                            btn_Error.Visible = true;
                            btn_Error.Text = "Mail Hatalı Girildi";
                        }
                    }
                    else
                    {
                        btn_Error.Visible = true;
                        btn_Error.Text = "Mail Hatalı Girildi";
                    }
                }
                else
                {
                    btn_Error.Visible = true;
                    btn_Error.Text = "Yönetici Bulunamadı";
                }
            }
            else
            {
                db.Yonetici.First(s => s.ID == Yonetici.ID).Aktifmi = true;
                YoneticiPanel_Load(null, null);
                new SerilisationStuff().Save(db);
                btn_Reset_Click(null, null);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            db.Yonetici.First(s => s.ID == Yonetici.ID).Aktifmi = false;
            new SerilisationStuff().Save(db);
            YoneticiPanel_Load(null, null);
            btn_Reset_Click(null, null);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Yonetici = null;
            tb_ID.Text = "";
            cb_Yetki.Items.Clear();
            tb_Ad.Text = "";
            tb_Soyad.Text = "";
            tb_ProfilFotografi.Text = "";
            tb_KullaniciAdi.Text = "";
            tb_Sifre.Text = "";
            tb_Mail.Text = "";
            btn_Sil.Enabled = false;
            btn_Save.Enabled = false;
            btn_ProfilResmi.Enabled = false;
        }

        private void DGV_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_Reset_Click(null, null);
                Yonetici yonetici = new Yonetici();
                yonetici.ID = Convert.ToInt32(DGV_YoneticiView.Rows[e.RowIndex].Cells[0].Value);
                yonetici.YoneticiTur_ID = Convert.ToInt32(DGV_YoneticiView.Rows[e.RowIndex].Cells[1].Value);
                yonetici.Isim = DGV_YoneticiView.Rows[e.RowIndex].Cells[3].Value.ToString();
                yonetici.SoyIsim = DGV_YoneticiView.Rows[e.RowIndex].Cells[4].Value.ToString();
                yonetici.KullaniciAdi = DGV_YoneticiView.Rows[e.RowIndex].Cells[5].Value.ToString();
                yonetici.ProfilFotografi = DGV_YoneticiView.Rows[e.RowIndex].Cells[6].Value.ToString();
                yonetici.Sifre = DGV_YoneticiView.Rows[e.RowIndex].Cells[7].Value.ToString();
                yonetici.Mail = DGV_YoneticiView.Rows[e.RowIndex].Cells[8].Value.ToString();
                yonetici.Aktifmi = Convert.ToBoolean(DGV_YoneticiView.Rows[e.RowIndex].Cells[9].Value);
                yonetici.YoneticiTur = db.YoneticiTur.First(s => s.ID == yonetici.YoneticiTur_ID);
                Yonetici = yonetici;

                tb_ID.Text = Yonetici.ID.ToString();
                tb_Ad.Text = Yonetici.Isim;
                tb_Soyad.Text = Yonetici.SoyIsim;
                foreach (var item in db.YoneticiTur)
                {
                    cb_Yetki.Items.Add(item.Ad);
                }
                foreach (var item in cb_Yetki.Items)
                {
                    if (Yonetici.YoneticiTur.Ad == item.ToString())
                    {
                        cb_Yetki.SelectedItem = item;
                        break;
                    }

                }
                tb_KullaniciAdi.Text = Yonetici.KullaniciAdi;
                tb_ProfilFotografi.Text = Yonetici.ProfilFotografi;
                tb_Sifre.Text = Yonetici.Sifre;
                tb_Mail.Text = Yonetici.Mail;
                btn_Save.Enabled = true;
                btn_Sil.Enabled = true;
                btn_ProfilResmi.Enabled = true;

                btn_Error.Visible = false;
            }
            catch (Exception ex)
            {
                btn_Error.Visible = true;
                btn_Error.Text = ex.Message;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                var p = new Pen(Color.Green, 1);

                #region Firma Resmi
                ////start: 0, panel1.Height - 60 
                ////target: panel1.Width, 18
                //g.DrawLine(p, new Point(0, panel1.Height - 60), new Point(20, panel1.Height - 60));
                //g.DrawLine(p, new Point(20, panel1.Height - 60), new Point(34, panel1.Height - 74));
                //g.DrawLine(p, new Point(34, panel1.Height - 74), new Point(34, 32));
                //g.DrawLine(p, new Point(34, 32), new Point(48, 19));
                //g.DrawLine(p, new Point(48, 19), new Point(panel1.Width, 19));

                ////g.DrawLine(p, new Point(0, panel1.Height - 60), new Point(panel1.Width, 18));
                #endregion



                #region Firma Arka Plan Resmi

                //start: 0, panel1.Heigh - 35
                //target: panel1.Width, 65
                g.DrawLine(p, new Point(0, panel1.Height - 35), new Point(30, panel1.Height - 35));
                g.DrawLine(p, new Point(30, panel1.Height - 35), new Point(44, panel1.Height - 49));
                g.DrawLine(p, new Point(44, panel1.Height - 49), new Point(44, 79));
                g.DrawLine(p, new Point(44, 79), new Point(59, 65));
                g.DrawLine(p, new Point(59, 65), new Point(panel1.Width, 65));

                //g.DrawLine(p, new Point(0, panel1.Height - 35), new Point(panel1.Width, 65));
                #endregion
            }
        }
    }
}
