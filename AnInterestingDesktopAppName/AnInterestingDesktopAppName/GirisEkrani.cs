using AnInterestingDesktopAppName.Classes;
using AnInterestingWebSiteName.Classes;
using AnInterestingWebSiteName.Models;
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
    public partial class GirisEkrani : Form
    {
        public bool Giris { get; set; }
        SerilisationStuff ss = new SerilisationStuff();
        
        BaseClass db = new SerilisationStuff().XMLDeserialiserWS();
        public GirisEkrani()
        {
            Statics.db = db;
            InitializeComponent();
        }

        private void GirisEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Giris == false)
            {
                Application.Exit();
            }
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            if (Statics.db == null)
            {
                MessageBox.Show(Text = "Belgeler Klasöründe Veritabanı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (db.Yonetici.Count(s => s.Mail.ToLower() == tb_Mail.Text.ToLower() && s.Sifre == tb_Sifre.Text && s.Aktifmi == true) > 0)
            {
                Statics.Yonetici = db.Yonetici.First(s => s.Mail.ToLower() == tb_Mail.Text && s.Sifre.ToLower() == tb_Sifre.Text);
                Giris = true;
                this.Close();
            }
            else
            {
                btn_Error.Visible = true;
                btn_Error.Text = "Hatalı Bilgi Girildi";
                Giris = false;
            }
        }
    }
}
