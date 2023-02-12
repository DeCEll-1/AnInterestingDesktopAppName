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
    public partial class OyunFotograflariPanel : Form
    {
        BaseClass db = Statics.db;
        public static OyunResimleri oyunResimleri { get; set; }
        public static int? Urun_ID { get; set; }
        public static bool a { get; set; }
        public static bool b { get; set; }

        public OyunFotograflariPanel()
        {
            b = true;
            InitializeComponent();
        }

        private void OyunFotograflariPanel_Load(object sender, EventArgs e)
        {
            DGV_YoneticiView.AutoGenerateColumns = true;

            cb_Urun.Items.Clear();

            foreach (var item in db.Urunler.ToList().Where(s => s.Aktifmi == true))
            {
                cb_Urun.Items.Add(item.Ad);
            }

            if (Urun_ID != null)
            {
                IEnumerable<AnInterestingWebSiteName.Models.OyunResimleri> fvds = db.OyunResimleri.ToList().AsEnumerable().Where(s => s.Aktifmi == !a && s.Oyun_ID == Urun_ID);

                DGV_YoneticiView.DataSource = fvds.ToList();
                DGV_YoneticiView.Columns["Aktifmi"].Visible = false;
                DGV_YoneticiView.Columns["Urunler"].Visible = false;

                foreach (var item in cb_Urun.Items)
                {
                    if (db.Urunler.First(s => s.ID == Urun_ID).Ad == item.ToString())
                    {
                        b = false;
                        cb_Urun.SelectedItem = item;
                        b = true;
                        break;
                    }
                }

            }


            panel1.SendToBack();
        }

        private void DGV_YoneticiView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_Reset_Click(null, null);
                OyunResimleri Urun = new OyunResimleri();
                Urun.ID = Convert.ToInt32(DGV_YoneticiView.Rows[e.RowIndex].Cells[0].Value);
                Urun.Oyun_ID = Convert.ToInt32(DGV_YoneticiView.Rows[e.RowIndex].Cells[1].Value);
                Urun.Urunler = db.Urunler.First(s => s.ID == Urun.Oyun_ID);
                Urun.Resim = DGV_YoneticiView.Rows[e.RowIndex].Cells[3].Value.ToString();

                Urun.Aktifmi = Convert.ToBoolean(DGV_YoneticiView.Rows[e.RowIndex].Cells[4].Value);

                oyunResimleri = Urun;

                tb_ID.Text = oyunResimleri.ID.ToString();

                tb_UrunID.Text = oyunResimleri.Oyun_ID.ToString();

                tb_FotografYolu.Text = oyunResimleri.Resim;

                btn_Sil.Enabled = true;

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
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (!a)
            {
                db.OyunResimleri.First(s => s.ID == oyunResimleri.ID).Aktifmi = false;
                new SerilisationStuff().Save(db);
                OyunFotograflariPanel_Load(null, null);
                btn_Reset_Click(null, null);
            }
            else
            {
                db.OyunResimleri.First(s => s.ID == oyunResimleri.ID).Aktifmi = true;
                OyunFotograflariPanel_Load(null, null);
                new SerilisationStuff().Save(db);
                btn_Reset_Click(null, null);
            }
        }

        private void btn_Aktif_Click(object sender, EventArgs e)
        {
            if (!a)
            {
                btn_Aktif.Text = "Silinmeyenleri Göster";
                btn_Sil.Text = "Geri Getir";

                btn_Sil.Enabled = false;

                a = true;
            }
            else
            {
                btn_Aktif.Text = "Silinenleri Göster";
                btn_Sil.Text = "Sil";

                btn_Sil.Enabled = false;

                a = false;
            }
            OyunFotograflariPanel_Load(null, null);
            btn_Reset_Click(null, null);
        }

        private void btn_ProfilResmi_Click(object sender, EventArgs e)
        {
            Process.Start(db.WebAdress + "/Fotograflar/UrunFotograflari/" + oyunResimleri.Resim);
        }

        private void cb_Urun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (b)
            {
                string UrunAd = "";
                foreach (var item in cb_Urun.Items)
                {
                    if (cb_Urun.SelectedItem.ToString() == item.ToString())
                    {
                        UrunAd = item.ToString();
                        break;
                    }
                }
                int UrunID = 0;
                foreach (var item in db.Urunler.ToList().Where(s => s.Aktifmi == true))
                {
                    if (item.Ad == UrunAd)
                    {
                        UrunID = item.ID;
                        break;
                    }
                }

                Urun_ID = UrunID;

                OyunFotograflariPanel_Load(null, null);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            oyunResimleri = null;
            tb_FotografYolu.Text = "";
            tb_ID.Text = "";
            tb_UrunID.Text = "";
            cb_Urun.SelectedItem = 0;
        }
    }
}
