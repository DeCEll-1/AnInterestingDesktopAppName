using AnInterestingDesktopAppName.Classes;
using AnInterestingWebSiteName.Classes;
using AnInterestingWebSiteName.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnInterestingDesktopAppName
{
    public partial class FirmaPanel : Form
    {
        BaseClass db = Statics.db;

        public static Firma firma { get; set; }

        public static bool a { get; set; }

        public FirmaPanel()
        {
            a = true;
            InitializeComponent();
        }

        private void FirmaPanel_Load(object sender, EventArgs e)
        {
            DGV_FirmaView.AutoGenerateColumns = true;

            IEnumerable<Firma> fvds = db.Firma.ToList().AsEnumerable().Where(s => s.Aktifmi == a);

            DGV_FirmaView.DataSource = fvds.ToList();

            DGV_FirmaView.Columns["Aktifmi"].Visible = false;

            panel1.SendToBack();
        }

        private void DGV_FirmaView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Firma f = new Firma();
                f.ID = Convert.ToInt32(DGV_FirmaView.Rows[e.RowIndex].Cells[0].Value);
                f.Ad = DGV_FirmaView.Rows[e.RowIndex].Cells[1].Value.ToString();
                //firma hakkında için CKEditorlü bir windows web formu yapmayacağım 
                //https://cdn.discordapp.com/emojis/1063522849417089105.webp?size=44&quality=lossless
                f.FirmaHakkinda = DGV_FirmaView.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.FirmaResmi = DGV_FirmaView.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.FirmaArkaPlanResmi = DGV_FirmaView.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.Mail = DGV_FirmaView.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.Aktifmi = Convert.ToBoolean(DGV_FirmaView.Rows[e.RowIndex].Cells[6].Value);

                firma = f;

                tb_FirmaID.Text = f.ID.ToString();
                tb_FirmaAdi.Text = f.Ad;
                tb_FirmaHakkinda.Text = f.FirmaHakkinda;
                tb_FirmaResmi.Text = f.FirmaResmi;
                tb_FirmaArkaPlanResmi.Text = f.FirmaArkaPlanResmi;
                tb_FirmaMail.Text = f.Mail;
                btn_Sil.Enabled = true;
                btn_Save.Enabled = true;
                btn_SeeCompany.Enabled = true;
                btn_FirmaResmiLink.Enabled = true;
                btn_FirmaArkaPlanResmiLink.Enabled = true;

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




            }
        }

        private void btn_FirmaArkaPlanResmiLink_Click(object sender, EventArgs e)
        {
            // /Fotograflar/UrunFotograflari/
            Process.Start(db.WebAdress + "/Fotograflar/FirmaFotograflari/" + firma.FirmaArkaPlanResmi);
        }

        private void btn_FirmaResmiLink_Click(object sender, EventArgs e)
        {
            Process.Start(db.WebAdress + "/Fotograflar/FirmaFotograflari/" + firma.FirmaResmi);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (a)
            {
                if (firma != null)
                {
                    if (tb_FirmaMail.Text.Contains("@"))
                    {
                        if (tb_FirmaMail.Text.Contains(".com"))
                        {
                            db.Firma.First(s => s.ID == firma.ID).Ad = tb_FirmaAdi.Text;
                            db.Firma.First(s => s.ID == firma.ID).Mail = tb_FirmaMail.Text;
                            FirmaPanel_Load(null, null);
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
                    btn_Error.Text = "Firma Bulunamadı";
                }
            }
            else
            {
                db.Firma.First(s => s.ID == firma.ID).Aktifmi = true;
                FirmaPanel_Load(null, null);
                new SerilisationStuff().Save(db);
                btn_Reset_Click(null, null);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            firma = null;
            tb_FirmaID.Text = "";
            tb_FirmaAdi.Text = "";
            tb_FirmaHakkinda.Text = "";
            tb_FirmaResmi.Text = "";
            tb_FirmaArkaPlanResmi.Text = "";
            tb_FirmaMail.Text = "";
            btn_SeeCompany.Enabled = false;
            btn_Sil.Enabled = false;
            btn_FirmaResmiLink.Enabled = false;
            btn_Save.Enabled = false;
            btn_FirmaArkaPlanResmiLink.Enabled = false;

        }

        private void btn_SeeCompany_Click(object sender, EventArgs e)
        {
            //firma için index yapmayı unutmuşum :(
            //yaptım geldim

            Process.Start(db.WebAdress + "UserFirma/Index/" + firma.ID);

        }

        private void btn_Aktif_Click(object sender, EventArgs e)
        {
            if (a)
            {
                btn_Aktif.Text = "Silinmeyenleri Göster";
                btn_Save.Text = "Geri Getir";
                btn_Sil.Visible = false;
                a = false;
                tb_FirmaAdi.Enabled = false;
                tb_FirmaMail.Enabled = false;
                FirmaPanel_Load(null, null);
            }
            else
            {
                btn_Aktif.Text = "Silinenleri Göster";
                btn_Save.Text = "Kaydet";
                a = true;
                btn_Sil.Visible = true;
                tb_FirmaAdi.Enabled = true;
                tb_FirmaMail.Enabled = true;
                FirmaPanel_Load(null, null);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            db.Firma.First(s => s.ID == firma.ID).Aktifmi = false;
            new SerilisationStuff().Save(db);
            FirmaPanel_Load(null, null);
            btn_Reset_Click(null, null);
        }
    }
}
//https://youtu.be/PAefYQe9hvc
//https://youtu.be/yModCU1OVHY banana