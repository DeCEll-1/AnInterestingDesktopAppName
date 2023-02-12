namespace AnInterestingDesktopAppName
{
    partial class YoneticiPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_DGV = new System.Windows.Forms.GroupBox();
            this.DGV_YoneticiView = new System.Windows.Forms.DataGridView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Aktif = new System.Windows.Forms.Button();
            this.btn_Error = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ProfilResmi = new System.Windows.Forms.Button();
            this.tb_Sifre = new System.Windows.Forms.TextBox();
            this.tb_ProfilFotografi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Ad = new System.Windows.Forms.TextBox();
            this.cb_Yetki = new System.Windows.Forms.ComboBox();
            this.gb_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_YoneticiView)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DGV
            // 
            this.gb_DGV.Controls.Add(this.DGV_YoneticiView);
            this.gb_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_DGV.Location = new System.Drawing.Point(0, 238);
            this.gb_DGV.Name = "gb_DGV";
            this.gb_DGV.Size = new System.Drawing.Size(854, 212);
            this.gb_DGV.TabIndex = 2;
            this.gb_DGV.TabStop = false;
            this.gb_DGV.Text = "Yönticiler:";
            // 
            // DGV_YoneticiView
            // 
            this.DGV_YoneticiView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_YoneticiView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_YoneticiView.Location = new System.Drawing.Point(3, 16);
            this.DGV_YoneticiView.Name = "DGV_YoneticiView";
            this.DGV_YoneticiView.ReadOnly = true;
            this.DGV_YoneticiView.Size = new System.Drawing.Size(848, 193);
            this.DGV_YoneticiView.TabIndex = 0;
            this.DGV_YoneticiView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_View_CellClick);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.Location = new System.Drawing.Point(363, 191);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(56, 41);
            this.btn_Sil.TabIndex = 30;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Aktif
            // 
            this.btn_Aktif.Location = new System.Drawing.Point(760, 124);
            this.btn_Aktif.Name = "btn_Aktif";
            this.btn_Aktif.Size = new System.Drawing.Size(94, 108);
            this.btn_Aktif.TabIndex = 29;
            this.btn_Aktif.Text = "Silinenleri Göster\t";
            this.btn_Aktif.UseVisualStyleBackColor = true;
            this.btn_Aktif.Click += new System.EventHandler(this.btn_Aktif_Click);
            // 
            // btn_Error
            // 
            this.btn_Error.Enabled = false;
            this.btn_Error.Location = new System.Drawing.Point(481, 188);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.Size = new System.Drawing.Size(207, 44);
            this.btn_Error.TabIndex = 28;
            this.btn_Error.UseVisualStyleBackColor = true;
            this.btn_Error.Visible = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(425, 191);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(50, 41);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(29, 12);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(94, 20);
            this.btn_Reset.TabIndex = 26;
            this.btn_Reset.Text = "Seçimi Sıfırla";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(355, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 150);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_ProfilResmi
            // 
            this.btn_ProfilResmi.Enabled = false;
            this.btn_ProfilResmi.Location = new System.Drawing.Point(760, 77);
            this.btn_ProfilResmi.Name = "btn_ProfilResmi";
            this.btn_ProfilResmi.Size = new System.Drawing.Size(94, 41);
            this.btn_ProfilResmi.TabIndex = 23;
            this.btn_ProfilResmi.Text = "Webde Gör";
            this.btn_ProfilResmi.UseVisualStyleBackColor = true;
            this.btn_ProfilResmi.Click += new System.EventHandler(this.btn_ProfilResmi_Click);
            // 
            // tb_Sifre
            // 
            this.tb_Sifre.Location = new System.Drawing.Point(190, 188);
            this.tb_Sifre.Name = "tb_Sifre";
            this.tb_Sifre.Size = new System.Drawing.Size(167, 20);
            this.tb_Sifre.TabIndex = 21;
            // 
            // tb_ProfilFotografi
            // 
            this.tb_ProfilFotografi.Enabled = false;
            this.tb_ProfilFotografi.Location = new System.Drawing.Point(190, 136);
            this.tb_ProfilFotografi.Name = "tb_ProfilFotografi";
            this.tb_ProfilFotografi.Size = new System.Drawing.Size(167, 20);
            this.tb_ProfilFotografi.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Yönetici Şifre:";
            // 
            // tb_KullaniciAdi
            // 
            this.tb_KullaniciAdi.Location = new System.Drawing.Point(190, 162);
            this.tb_KullaniciAdi.Name = "tb_KullaniciAdi";
            this.tb_KullaniciAdi.Size = new System.Drawing.Size(167, 20);
            this.tb_KullaniciAdi.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Yönetici Profil Fotoğrafı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yönetici Kullanıcı Adı:";
            // 
            // tb_Soyad
            // 
            this.tb_Soyad.Location = new System.Drawing.Point(190, 110);
            this.tb_Soyad.Name = "tb_Soyad";
            this.tb_Soyad.Size = new System.Drawing.Size(167, 20);
            this.tb_Soyad.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yönetici Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yöneticinin Yetkisi:";
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(190, 32);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(167, 20);
            this.tb_ID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Yönetici ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Yönetici Mail:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(190, 214);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(167, 20);
            this.tb_Mail.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Yönetici Adı:";
            // 
            // tb_Ad
            // 
            this.tb_Ad.Location = new System.Drawing.Point(190, 84);
            this.tb_Ad.Name = "tb_Ad";
            this.tb_Ad.Size = new System.Drawing.Size(167, 20);
            this.tb_Ad.TabIndex = 16;
            // 
            // cb_Yetki
            // 
            this.cb_Yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Yetki.FormattingEnabled = true;
            this.cb_Yetki.Location = new System.Drawing.Point(190, 58);
            this.cb_Yetki.Name = "cb_Yetki";
            this.cb_Yetki.Size = new System.Drawing.Size(167, 21);
            this.cb_Yetki.TabIndex = 31;
            // 
            // YoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.cb_Yetki);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.tb_Soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Aktif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Error);
            this.Controls.Add(this.tb_KullaniciAdi);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ProfilResmi);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.tb_Sifre);
            this.Controls.Add(this.tb_ProfilFotografi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Ad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_DGV);
            this.Name = "YoneticiPanel";
            this.Text = "YoneticiPanel";
            this.Load += new System.EventHandler(this.YoneticiPanel_Load);
            this.gb_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_YoneticiView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DGV;
        private System.Windows.Forms.DataGridView DGV_YoneticiView;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Aktif;
        private System.Windows.Forms.Button btn_Error;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ProfilResmi;
        private System.Windows.Forms.TextBox tb_Sifre;
        private System.Windows.Forms.TextBox tb_ProfilFotografi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_KullaniciAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Ad;
        private System.Windows.Forms.ComboBox cb_Yetki;
    }
}