using AnInterestingDesktopAppName.Classes;
using AnInterestingWebSiteName.Classes;
using AnInterestingWebSiteName.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnInterestingDesktopAppName
{
    public partial class KullaniciPanel : Form
    {
        BaseClass db = Statics.db;
        public static Kullanici kullanici { get; set; }
        public static bool a { get; set; }
        public KullaniciPanel()
        {
            a = true;
            InitializeComponent();
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            DGV_YoneticiView.AutoGenerateColumns = true;

            IEnumerable<AnInterestingWebSiteName.Models.Kullanici> fvds = db.Kullanici.ToList().AsEnumerable().Where(s => s.Aktifmi == a);

            DGV_YoneticiView.DataSource = fvds.ToList();
            DGV_YoneticiView.Columns["Aktifmi"].Visible = false;

            panel1.SendToBack();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (a)
            {
                if (kullanici != null)
                {
                    if (tb_Mail.Text.Contains("@"))
                    {
                        if (tb_Mail.Text.Contains(".com"))
                        {
                            db.Kullanici.First(s => s.ID == kullanici.ID).Ad = tb_Ad.Text;
                            db.Kullanici.First(s => s.ID == kullanici.ID).Sifre = tb_Sifre.Text;
                            db.Kullanici.First(s => s.ID == kullanici.ID).Mail = tb_Mail.Text;
                            KullaniciPanel_Load(null, null);
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
                db.Kullanici.First(s => s.ID == kullanici.ID).Aktifmi = true;
                KullaniciPanel_Load(null, null);
                new SerilisationStuff().Save(db);
                btn_Reset_Click(null, null);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            db.Kullanici.First(s => s.ID == kullanici.ID).Aktifmi = false;
            new SerilisationStuff().Save(db);
            KullaniciPanel_Load(null, null);
            btn_Reset_Click(null, null);
        }

        private void btn_Aktif_Click(object sender, EventArgs e)
        {
            if (a)
            {
                btn_Aktif.Text = "Silinmeyenleri Göster";
                btn_Save.Text = "Geri Getir";
                btn_Sil.Visible = false;
                btn_Sil.Enabled = false;
                a = false;
                tb_Ad.Enabled = false;
                tb_Sifre.Enabled = false;
                tb_Mail.Enabled = false;
                tb_Aciklama.Enabled = false;
                KullaniciPanel_Load(null, null);
            }
            else
            {
                btn_Aktif.Text = "Silinenleri Göster";
                btn_Save.Text = "Kaydet";
                btn_Sil.Visible = true;
                btn_Sil.Enabled = true;
                a = true;
                tb_Ad.Enabled = true;
                tb_Sifre.Enabled = true;
                tb_Mail.Enabled = true;
                tb_Aciklama.Enabled = true;
                KullaniciPanel_Load(null, null);
            }
            btn_Reset_Click(null, null);
        }

        private void btn_IkonYolu_Click(object sender, EventArgs e)
        {
            Process.Start(db.WebAdress + "/Fotograflar/KullaniciFotograflari/" + kullanici.ProfilResmi);
        }

        private void btn_WebdeGor_Click(object sender, EventArgs e)
        {
            Process.Start(db.WebAdress + "User/Index/" + kullanici.ID);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            kullanici = null;
            tb_ID.Text = "";
            tb_Ad.Text = "";
            tb_Ad.Enabled = false;
            tb_Sifre.Text = "";
            tb_Sifre.Enabled = false;
            tb_ProfilFotografiYolu.Text = "";
            tb_Mail.Text = "";
            tb_Mail.Enabled = false;
            tb_Aciklama.Text = "";
            tb_Aciklama.Enabled = false;

            btn_Save.Enabled = false;
            btn_Sil.Enabled = false;
            btn_ProfilFotografi.Enabled = false;
            btn_WebdeGor.Enabled = false;
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
                //start: 0, 90 
                //target: 342, 18
                g.DrawLine(p, new Point(0, panel1.Height - 60), new Point(20, panel1.Height - 60));
                g.DrawLine(p, new Point(20, panel1.Height - 60), new Point(34, panel1.Height - 74));
                g.DrawLine(p, new Point(34, panel1.Height - 74), new Point(34, 32));
                g.DrawLine(p, new Point(34, 32), new Point(48, 19));
                g.DrawLine(p, new Point(48, 19), new Point(panel1.Width, 19));

                //g.DrawLine(p, new Point(0, panel1.Height - 60), new Point(panel1.Width, 18));
                #endregion

                #region Firma Arka Plan Resmi
                ////start: 0, panel1.Heigh - 35
                ////target: panel1.Width, 65
                //g.DrawLine(p, new Point(0, panel1.Height - 35), new Point(30, panel1.Height - 35));
                //g.DrawLine(p, new Point(30, panel1.Height - 35), new Point(44, panel1.Height - 49));
                //g.DrawLine(p, new Point(44, panel1.Height - 49), new Point(44, 79));
                //g.DrawLine(p, new Point(44, 79), new Point(59, 65));
                //g.DrawLine(p, new Point(59, 65), new Point(panel1.Width, 65));

                ////g.DrawLine(p, new Point(0, panel1.Height - 35), new Point(panel1.Width, 65));
                #endregion

                #region Firma Arka Plan Resmi
                ////start: 0, panel1.Height-10
                ////target: panel1.Width, 112

                //g.DrawLine(p, new Point(0, 140), new Point(40, 140));
                //g.DrawLine(p, new Point(40, 140), new Point(68, 112));
                //g.DrawLine(p, new Point(68, 112), new Point(panel1.Width, 112));

                ////g.DrawLine(p, new Point(0, panel1.Height-10), new Point(panel1.Width, 112));
                #endregion
            }
        }

        private void DGV_YoneticiView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_Reset_Click(null, null);
                Kullanici Kullanici = new Kullanici();
                Kullanici.ID = Convert.ToInt32(DGV_YoneticiView.Rows[e.RowIndex].Cells[0].Value);
                Kullanici.Ad = DGV_YoneticiView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Kullanici.Sifre = DGV_YoneticiView.Rows[e.RowIndex].Cells[2].Value.ToString();
                Kullanici.Mail = DGV_YoneticiView.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (DGV_YoneticiView.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    Kullanici.Aciklama = DGV_YoneticiView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tb_Aciklama.Text = Kullanici.Aciklama;
                }
                Kullanici.ProfilResmi = DGV_YoneticiView.Rows[e.RowIndex].Cells[5].Value.ToString();

                Kullanici.Aktifmi = Convert.ToBoolean(DGV_YoneticiView.Rows[e.RowIndex].Cells[6].Value);

                kullanici = Kullanici;



                tb_ID.Text = kullanici.ID.ToString();
                tb_Ad.Text = kullanici.Ad;
                tb_Ad.Enabled = true;
                tb_Sifre.Text = kullanici.Sifre;
                tb_Sifre.Enabled = true;
                tb_Mail.Text = kullanici.Mail;
                tb_Mail.Enabled = true;
                tb_ProfilFotografiYolu.Text = kullanici.ProfilResmi;


                btn_Save.Enabled = true;
                btn_Sil.Enabled = true;
                btn_WebdeGor.Enabled = true;
                btn_ProfilFotografi.Enabled = true;
                if (a)
                {
                    tb_Ad.Enabled = true;
                    tb_Sifre.Enabled = true;
                    tb_Mail.Enabled = true;
                }
                else
                {
                    tb_Ad.Enabled = true;
                    tb_Sifre.Enabled = true;
                    tb_Mail.Enabled = true;
                }

                btn_Error.Visible = false;
            }
            catch (Exception ex)
            {
                btn_Error.Visible = true;
                btn_Error.Text = ex.Message;
            }
        }
    }
}
