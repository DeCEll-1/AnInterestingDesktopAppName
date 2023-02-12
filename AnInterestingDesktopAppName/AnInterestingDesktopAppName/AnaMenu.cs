using AnInterestingDesktopAppName.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnInterestingDesktopAppName
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            GirisEkrani ge = new GirisEkrani();
            ge.ShowDialog();
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            tssl_Pusher.Spring = true;
            tssl_Name.Text = Statics.Yonetici.KullaniciAdi;
        }

        private void TSMIYonetici_Click(object sender, EventArgs e)
        {
            YoneticiPanel yp = new YoneticiPanel();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == yp.GetType())
                {
                    this.ActivateMdiChild(item);
                    yp.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                yp.MdiParent = this;
                yp.Show();
            }
        }

        private void TSMIFirma_Click(object sender, EventArgs e)
        {
            FirmaPanel fp = new FirmaPanel();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == fp.GetType())
                {
                    this.ActivateMdiChild(item);
                    fp.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                fp.MdiParent = this;
                fp.Show();
            }
        }

        private void TSMIUrun_Click(object sender, EventArgs e)
        {
            UrunPanel up = new UrunPanel();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == up.GetType())
                {
                    this.ActivateMdiChild(item);
                    up.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                up.MdiParent = this;
                up.Show();
            }
        }

        private void TSMIKullanici_Click(object sender, EventArgs e)
        {
            KullaniciPanel kp = new KullaniciPanel();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == kp.GetType())
                {
                    this.ActivateMdiChild(item);
                    kp.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                kp.MdiParent = this;
                kp.Show();
            }
        }

        private void oyunFotoğrafPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OyunFotograflariPanel ofp = new OyunFotograflariPanel();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == ofp.GetType())
                {
                    this.ActivateMdiChild(item);
                    ofp.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                ofp.MdiParent = this;
                ofp.Show();
            }
        }
    }
}
