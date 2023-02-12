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
    public partial class UrunPanel : Form
    {
        BaseClass db = Statics.db;
        public static Urunler urun { get; set; }
        public static bool a { get; set; }
        public UrunPanel()
        {
            a = true;
            InitializeComponent();
        }

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            DGV_YoneticiView.AutoGenerateColumns = true;

            IEnumerable<AnInterestingWebSiteName.Models.Urunler> fvds = db.Urunler.ToList().AsEnumerable().Where(s => s.Aktifmi == a && db.Firma.First(x => x.ID == s.Yapimci_ID).Aktifmi == true && db.Firma.First(z => z.ID == s.Yayinci_ID).Aktifmi == true);

            DGV_YoneticiView.DataSource = fvds.ToList();
            DGV_YoneticiView.Columns["Aktifmi"].Visible = false;

            panel1.SendToBack();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            db.Urunler.First(s => s.ID == urun.ID).Aktifmi = false;
            new SerilisationStuff().Save(db);
            UrunPanel_Load(null, null);
            btn_Reset_Click(null, null);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (a)
            {
                if (urun != null)
                {
                    string yayinciad = "";
                    foreach (var item in cb_Yayinci.Items)
                    {
                        if (cb_Yayinci.SelectedItem.ToString() == item.ToString())
                        {
                            yayinciad = item.ToString();
                            break;
                        }
                    }
                    int yayinciID = 0;
                    foreach (var item in db.Firma.ToList().Where(s => s.Aktifmi == true))
                    {
                        if (item.Ad == yayinciad)
                        {
                            yayinciID = item.ID;
                            break;
                        }
                    }
                    db.Urunler.First(s => s.ID == urun.ID).Yayinci_ID = yayinciID;
                    string yapimciad = "";
                    foreach (var item in cb_Yapimci.Items)
                    {
                        if (cb_Yapimci.SelectedItem.ToString() == item.ToString())
                        {
                            yapimciad = item.ToString();
                            break;
                        }
                    }
                    int yapimciID = 0;
                    foreach (var item in db.Firma.ToList().Where(s => s.Aktifmi == true))
                    {
                        if (item.Ad == yapimciad)
                        {
                            yapimciID = item.ID;
                            break;
                        }
                    }
                    db.Urunler.First(s => s.ID == urun.ID).Yapimci_ID = yapimciID;
                    db.Urunler.First(s => s.ID == urun.ID).Ad = tb_UrununAdi.Text;
                    db.Urunler.First(s => s.ID == urun.ID).Fiyat = Convert.ToDouble(nud_Fiyat.Text);
                    db.Urunler.First(s => s.ID == urun.ID).Indirim = Convert.ToByte(nud_Indirim.Text);
                    db.Urunler.First(s => s.ID == urun.ID).IndirimliFiyat = Convert.ToDouble(nud_Fiyat.Text) - ((Convert.ToDouble(nud_Fiyat.Text) * Convert.ToByte(nud_Indirim.Text)) / 100);
                    UrunPanel_Load(null, null);
                    new SerilisationStuff().Save(db);
                }
                else
                {
                    btn_Error.Visible = true;
                    btn_Error.Text = "Firma Bulunamadı";
                }
            }
            else
            {
                db.Urunler.First(s => s.ID == urun.ID).Aktifmi = true;
                UrunPanel_Load(null, null);
                new SerilisationStuff().Save(db);
                btn_Reset_Click(null, null);
            }
        }

        private void btn_Aktif_Click(object sender, EventArgs e)
        {
            if (a)
            {
                btn_Aktif.Text = "Silinmeyenleri Göster";
                btn_Save.Text = "Geri Getir";
                btn_Sil.Visible = false;
                a = false;
                tb_UrununAdi.Enabled = false;
                tb_UrununAdi.Enabled = false;
                tb_Aciklama.Enabled = false;
                cb_Yayinci.Enabled = false;
                cb_Yapimci.Enabled = false;
                UrunPanel_Load(null, null);
            }
            else
            {
                btn_Aktif.Text = "Silinenleri Göster";
                btn_Save.Text = "Kaydet";
                btn_Sil.Visible = true;
                a = true;
                tb_UrununAdi.Enabled = true;
                btn_Sil.Enabled = true;
                tb_UrununAdi.Enabled = true;
                cb_Yayinci.Enabled = true;
                UrunPanel_Load(null, null);
            }
            btn_Reset_Click(null, null);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            urun = null;
            cb_Yapimci.Enabled = false;
            cb_Yapimci.Items.Clear();
            cb_Yayinci.Enabled = false;
            cb_Yayinci.Items.Clear();
            tb_ID.Text = "";
            tb_ArkaPlanResimYolu.Text = "";
            tb_IkonYolu.Text = "";
            tb_TamResimYolu.Text = "";
            tb_UrununAdi.Text = "";
            tb_UrununAdi.Enabled = false;
            nud_Fiyat.Text = "";
            nud_Fiyat.Enabled = false;
            nud_Indirim.Text = "";
            nud_Indirim.Enabled = false;
            btn_Save.Enabled = false;
            btn_Sil.Enabled = false;
            btn_TamResimYolu.Enabled = false;
            btn_IkonYolu.Enabled = false;
            btn_WebdeGor.Enabled = false;
            btn_ArkaPlanResimYolu.Enabled = false;
        }

        private void DGV_YoneticiView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_Reset_Click(null, null);
                Urunler Urun = new Urunler();
                Urun.ID = Convert.ToInt32(DGV_YoneticiView.Rows[e.RowIndex].Cells[0].Value);
                Urun.Yapimci_ID = Convert.ToInt32(DGV_YoneticiView.Rows[e.RowIndex].Cells[1].Value);
                Urun.Yayinci_ID = Convert.ToInt32(DGV_YoneticiView.Rows[e.RowIndex].Cells[3].Value);
                Urun.Ad = DGV_YoneticiView.Rows[e.RowIndex].Cells[5].Value.ToString();
                Urun.Aciklama = DGV_YoneticiView.Rows[e.RowIndex].Cells[6].Value.ToString();
                Urun.Fiyat = Convert.ToDouble(DGV_YoneticiView.Rows[e.RowIndex].Cells[10].Value);
                Urun.Indirim = Convert.ToByte(DGV_YoneticiView.Rows[e.RowIndex].Cells[11].Value);
                Urun.IndirimliFiyat = Convert.ToDouble(DGV_YoneticiView.Rows[e.RowIndex].Cells[12].Value);
                Urun.IkonYolu = DGV_YoneticiView.Rows[e.RowIndex].Cells[13].Value.ToString();
                Urun.TamResimYolu = DGV_YoneticiView.Rows[e.RowIndex].Cells[14].Value.ToString();
                Urun.ArkaPlanResmi = DGV_YoneticiView.Rows[e.RowIndex].Cells[15].Value.ToString();

                Urun.Yayinci = db.Firma.First(s => s.ID == Urun.Yayinci_ID);

                Urun.Yapimci = db.Firma.First(s => s.ID == Urun.Yapimci_ID);

                Urun.Aktifmi = Convert.ToBoolean(DGV_YoneticiView.Rows[e.RowIndex].Cells[17].Value);

                urun = Urun;



                foreach (var item in db.Firma.ToList().Where(s => s.Aktifmi == true))
                {
                    cb_Yapimci.Items.Add(item.Ad);
                }
                foreach (var item in cb_Yapimci.Items)
                {
                    if (urun.Yapimci.Ad == item.ToString())
                    {
                        cb_Yapimci.SelectedItem = item;
                        break;
                    }
                }
                foreach (var item in db.Firma.ToList().Where(s => s.Aktifmi == true))
                {
                    cb_Yayinci.Items.Add(item.Ad);
                }
                foreach (var item in cb_Yayinci.Items)
                {
                    if (urun.Yayinci.Ad == item.ToString())
                    {
                        cb_Yayinci.SelectedItem = item;
                        break;
                    }
                }
                tb_ID.Text = urun.ID.ToString();
                tb_ArkaPlanResimYolu.Text = urun.ArkaPlanResmi;
                tb_IkonYolu.Text = urun.IkonYolu;
                tb_TamResimYolu.Text = urun.TamResimYolu;
                tb_UrununAdi.Text = urun.Ad;
                tb_UrununAdi.Enabled = true;
                nud_Fiyat.Text = urun.Fiyat.ToString();
                nud_Fiyat.Enabled = true;
                nud_Indirim.Text = urun.Indirim.ToString();
                nud_Indirim.Enabled = true;
                btn_Save.Enabled = true;
                btn_Sil.Enabled = true;
                btn_TamResimYolu.Enabled = true;
                btn_IkonYolu.Enabled = true;
                btn_WebdeGor.Enabled = true;
                btn_ArkaPlanResimYolu.Enabled = true;
                if (a)
                {
                    cb_Yapimci.Enabled = true;
                    cb_Yayinci.Enabled = true;
                }
                else
                {
                    cb_Yapimci.Enabled = false;
                    cb_Yayinci.Enabled = false;
                }

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
                //start: 0, panel1.Height - 60 
                //target: panel1.Width, 18
                g.DrawLine(p, new Point(0, panel1.Height - 60), new Point(20, panel1.Height - 60));
                g.DrawLine(p, new Point(20, panel1.Height - 60), new Point(34, panel1.Height - 74));
                g.DrawLine(p, new Point(34, panel1.Height - 74), new Point(34, 32));
                g.DrawLine(p, new Point(34, 32), new Point(48, 19));
                g.DrawLine(p, new Point(48, 19), new Point(panel1.Width, 19));

                //g.DrawLine(p, new Point(0, panel1.Height - 60), new Point(panel1.Width, 18));
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

                #region Firma Arka Plan Resmi

                //start: 0, panel1.Height-10
                //target: panel1.Width, 112

                g.DrawLine(p, new Point(0, 140), new Point(40, 140));
                g.DrawLine(p, new Point(40, 140), new Point(68, 112));
                g.DrawLine(p, new Point(68, 112), new Point(panel1.Width, 112));

                //g.DrawLine(p, new Point(0, panel1.Height-10), new Point(panel1.Width, 112));
                #endregion
            }
        }

        private void btn_ArkaPlanResimYolu_Click(object sender, EventArgs e)
        {
            Process.Start(db.WebAdress + "/Fotograflar/UrunFotograflari/" + urun.ArkaPlanResmi);
        }

        private void btn_TamResimYolu_Click(object sender, EventArgs e)
        {
            Process.Start(db.WebAdress + "/Fotograflar/UrunFotograflari/" + urun.TamResimYolu);
        }

        private void btn_IkonYolu_Click(object sender, EventArgs e)
        {
            Process.Start(db.WebAdress + "/Fotograflar/UrunFotograflari/" + urun.IkonYolu);
        }

        private void btn_WebdeGor_Click(object sender, EventArgs e)
        {
            Process.Start(db.WebAdress + "UserUrun/Index/" + urun.ID);
        }
    }
}
