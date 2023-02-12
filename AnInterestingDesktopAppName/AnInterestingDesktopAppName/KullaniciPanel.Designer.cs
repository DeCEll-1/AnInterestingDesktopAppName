namespace AnInterestingDesktopAppName
{
    partial class KullaniciPanel
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
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_WebdeGor = new System.Windows.Forms.Button();
            this.btn_ProfilFotografi = new System.Windows.Forms.Button();
            this.tb_ProfilFotografiYolu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Aktif = new System.Windows.Forms.Button();
            this.btn_Error = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_DGV = new System.Windows.Forms.GroupBox();
            this.DGV_YoneticiView = new System.Windows.Forms.DataGridView();
            this.tb_Sifre = new System.Windows.Forms.TextBox();
            this.tb_Aciklama = new System.Windows.Forms.TextBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_YoneticiView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.Location = new System.Drawing.Point(392, 179);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(56, 44);
            this.btn_Sil.TabIndex = 83;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_WebdeGor
            // 
            this.btn_WebdeGor.Enabled = false;
            this.btn_WebdeGor.Location = new System.Drawing.Point(163, 3);
            this.btn_WebdeGor.Name = "btn_WebdeGor";
            this.btn_WebdeGor.Size = new System.Drawing.Size(167, 20);
            this.btn_WebdeGor.TabIndex = 87;
            this.btn_WebdeGor.Text = "Kullanıcıyı Webde Gör";
            this.btn_WebdeGor.UseVisualStyleBackColor = true;
            this.btn_WebdeGor.Click += new System.EventHandler(this.btn_WebdeGor_Click);
            // 
            // btn_ProfilFotografi
            // 
            this.btn_ProfilFotografi.Enabled = false;
            this.btn_ProfilFotografi.Location = new System.Drawing.Point(667, 21);
            this.btn_ProfilFotografi.Name = "btn_ProfilFotografi";
            this.btn_ProfilFotografi.Size = new System.Drawing.Size(94, 39);
            this.btn_ProfilFotografi.TabIndex = 86;
            this.btn_ProfilFotografi.Text = "Webde Gör";
            this.btn_ProfilFotografi.UseVisualStyleBackColor = true;
            this.btn_ProfilFotografi.Click += new System.EventHandler(this.btn_IkonYolu_Click);
            // 
            // tb_ProfilFotografiYolu
            // 
            this.tb_ProfilFotografiYolu.Enabled = false;
            this.tb_ProfilFotografiYolu.Location = new System.Drawing.Point(163, 101);
            this.tb_ProfilFotografiYolu.Name = "tb_ProfilFotografiYolu";
            this.tb_ProfilFotografiYolu.Size = new System.Drawing.Size(167, 20);
            this.tb_ProfilFotografiYolu.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Kullanıcı Profil Fotoğrafı:";
            // 
            // btn_Aktif
            // 
            this.btn_Aktif.Location = new System.Drawing.Point(667, 160);
            this.btn_Aktif.Name = "btn_Aktif";
            this.btn_Aktif.Size = new System.Drawing.Size(94, 61);
            this.btn_Aktif.TabIndex = 82;
            this.btn_Aktif.Text = "Silinenleri Göster\t";
            this.btn_Aktif.UseVisualStyleBackColor = true;
            this.btn_Aktif.Click += new System.EventHandler(this.btn_Aktif_Click);
            // 
            // btn_Error
            // 
            this.btn_Error.Enabled = false;
            this.btn_Error.Location = new System.Drawing.Point(454, 179);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.Size = new System.Drawing.Size(207, 44);
            this.btn_Error.TabIndex = 81;
            this.btn_Error.UseVisualStyleBackColor = true;
            this.btn_Error.Visible = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(336, 179);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(50, 44);
            this.btn_Save.TabIndex = 80;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(2, 3);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(94, 20);
            this.btn_Reset.TabIndex = 79;
            this.btn_Reset.Text = "Seçimi Sıfırla";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(328, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 150);
            this.panel1.TabIndex = 78;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_Ad
            // 
            this.tb_Ad.Enabled = false;
            this.tb_Ad.Location = new System.Drawing.Point(163, 49);
            this.tb_Ad.Name = "tb_Ad";
            this.tb_Ad.Size = new System.Drawing.Size(167, 20);
            this.tb_Ad.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Kullanıcı Maili:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Kullanıcı Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(163, 23);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(167, 20);
            this.tb_ID.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Kullanıcı ID:";
            // 
            // gb_DGV
            // 
            this.gb_DGV.Controls.Add(this.DGV_YoneticiView);
            this.gb_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_DGV.Location = new System.Drawing.Point(0, 238);
            this.gb_DGV.Name = "gb_DGV";
            this.gb_DGV.Size = new System.Drawing.Size(768, 212);
            this.gb_DGV.TabIndex = 59;
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
            this.DGV_YoneticiView.Size = new System.Drawing.Size(762, 193);
            this.DGV_YoneticiView.TabIndex = 0;
            this.DGV_YoneticiView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_YoneticiView_CellClick);
            // 
            // tb_Sifre
            // 
            this.tb_Sifre.Enabled = false;
            this.tb_Sifre.Location = new System.Drawing.Point(163, 75);
            this.tb_Sifre.Name = "tb_Sifre";
            this.tb_Sifre.Size = new System.Drawing.Size(167, 20);
            this.tb_Sifre.TabIndex = 73;
            // 
            // tb_Aciklama
            // 
            this.tb_Aciklama.Enabled = false;
            this.tb_Aciklama.Location = new System.Drawing.Point(3, 172);
            this.tb_Aciklama.Multiline = true;
            this.tb_Aciklama.Name = "tb_Aciklama";
            this.tb_Aciklama.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_Aciklama.Size = new System.Drawing.Size(319, 51);
            this.tb_Aciklama.TabIndex = 88;
            // 
            // tb_Mail
            // 
            this.tb_Mail.Enabled = false;
            this.tb_Mail.Location = new System.Drawing.Point(163, 127);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(167, 20);
            this.tb_Mail.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Kullanıcı Açıklaması:";
            // 
            // KullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.tb_Aciklama);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_WebdeGor);
            this.Controls.Add(this.btn_ProfilFotografi);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.tb_ProfilFotografiYolu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Aktif);
            this.Controls.Add(this.btn_Error);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Sifre);
            this.Controls.Add(this.tb_Ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_DGV);
            this.Name = "KullaniciPanel";
            this.Text = "KullaniciPanel";
            this.Load += new System.EventHandler(this.KullaniciPanel_Load);
            this.gb_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_YoneticiView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_WebdeGor;
        private System.Windows.Forms.Button btn_ProfilFotografi;
        private System.Windows.Forms.TextBox tb_ProfilFotografiYolu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Aktif;
        private System.Windows.Forms.Button btn_Error;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_DGV;
        private System.Windows.Forms.DataGridView DGV_YoneticiView;
        private System.Windows.Forms.TextBox tb_Sifre;
        private System.Windows.Forms.TextBox tb_Aciklama;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label label4;
    }
}