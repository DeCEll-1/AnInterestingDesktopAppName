namespace AnInterestingDesktopAppName
{
    partial class UrunPanel
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
            this.DGV_YoneticiView = new System.Windows.Forms.DataGridView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.tb_IkonYolu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Aktif = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Error = new System.Windows.Forms.Button();
            this.tb_ArkaPlanResimYolu = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TamResimYolu = new System.Windows.Forms.Button();
            this.tb_Aciklama = new System.Windows.Forms.TextBox();
            this.tb_UrununAdi = new System.Windows.Forms.TextBox();
            this.tb_TamResimYolu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_DGV = new System.Windows.Forms.GroupBox();
            this.btn_IkonYolu = new System.Windows.Forms.Button();
            this.cb_Yayinci = new System.Windows.Forms.ComboBox();
            this.cb_Yapimci = new System.Windows.Forms.ComboBox();
            this.btn_WebdeGor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_Fiyat = new System.Windows.Forms.NumericUpDown();
            this.nud_Indirim = new System.Windows.Forms.NumericUpDown();
            this.btn_ArkaPlanResimYolu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_YoneticiView)).BeginInit();
            this.gb_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Indirim)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_YoneticiView
            // 
            this.DGV_YoneticiView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_YoneticiView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_YoneticiView.Location = new System.Drawing.Point(3, 16);
            this.DGV_YoneticiView.Name = "DGV_YoneticiView";
            this.DGV_YoneticiView.ReadOnly = true;
            this.DGV_YoneticiView.Size = new System.Drawing.Size(1010, 193);
            this.DGV_YoneticiView.TabIndex = 0;
            this.DGV_YoneticiView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_YoneticiView_CellClick);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.Location = new System.Drawing.Point(635, 182);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(56, 44);
            this.btn_Sil.TabIndex = 54;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // tb_IkonYolu
            // 
            this.tb_IkonYolu.Enabled = false;
            this.tb_IkonYolu.Location = new System.Drawing.Point(163, 104);
            this.tb_IkonYolu.Name = "tb_IkonYolu";
            this.tb_IkonYolu.Size = new System.Drawing.Size(167, 20);
            this.tb_IkonYolu.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ürünün İkon Yolu:";
            // 
            // btn_Aktif
            // 
            this.btn_Aktif.Location = new System.Drawing.Point(910, 163);
            this.btn_Aktif.Name = "btn_Aktif";
            this.btn_Aktif.Size = new System.Drawing.Size(94, 61);
            this.btn_Aktif.TabIndex = 53;
            this.btn_Aktif.Text = "Silinenleri Göster\t";
            this.btn_Aktif.UseVisualStyleBackColor = true;
            this.btn_Aktif.Click += new System.EventHandler(this.btn_Aktif_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ürünün Arka Plan Resim Yolu:";
            // 
            // btn_Error
            // 
            this.btn_Error.Enabled = false;
            this.btn_Error.Location = new System.Drawing.Point(697, 182);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.Size = new System.Drawing.Size(207, 44);
            this.btn_Error.TabIndex = 52;
            this.btn_Error.UseVisualStyleBackColor = true;
            this.btn_Error.Visible = false;
            // 
            // tb_ArkaPlanResimYolu
            // 
            this.tb_ArkaPlanResimYolu.Enabled = false;
            this.tb_ArkaPlanResimYolu.Location = new System.Drawing.Point(163, 156);
            this.tb_ArkaPlanResimYolu.Name = "tb_ArkaPlanResimYolu";
            this.tb_ArkaPlanResimYolu.Size = new System.Drawing.Size(167, 20);
            this.tb_ArkaPlanResimYolu.TabIndex = 43;
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(579, 182);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(50, 44);
            this.btn_Save.TabIndex = 51;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(2, 6);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(94, 20);
            this.btn_Reset.TabIndex = 50;
            this.btn_Reset.Text = "Seçimi Sıfırla";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(328, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 150);
            this.panel1.TabIndex = 49;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_TamResimYolu
            // 
            this.btn_TamResimYolu.Enabled = false;
            this.btn_TamResimYolu.Location = new System.Drawing.Point(910, 69);
            this.btn_TamResimYolu.Name = "btn_TamResimYolu";
            this.btn_TamResimYolu.Size = new System.Drawing.Size(94, 41);
            this.btn_TamResimYolu.TabIndex = 48;
            this.btn_TamResimYolu.Text = "Webde Gör";
            this.btn_TamResimYolu.UseVisualStyleBackColor = true;
            this.btn_TamResimYolu.Click += new System.EventHandler(this.btn_TamResimYolu_Click);
            // 
            // tb_Aciklama
            // 
            this.tb_Aciklama.Enabled = false;
            this.tb_Aciklama.Location = new System.Drawing.Point(163, 208);
            this.tb_Aciklama.Name = "tb_Aciklama";
            this.tb_Aciklama.Size = new System.Drawing.Size(167, 20);
            this.tb_Aciklama.TabIndex = 46;
            this.tb_Aciklama.Text = "Açıklama Webde Değiştirilmelidir";
            // 
            // tb_UrununAdi
            // 
            this.tb_UrununAdi.Enabled = false;
            this.tb_UrununAdi.Location = new System.Drawing.Point(163, 182);
            this.tb_UrununAdi.Name = "tb_UrununAdi";
            this.tb_UrununAdi.Size = new System.Drawing.Size(167, 20);
            this.tb_UrununAdi.TabIndex = 47;
            // 
            // tb_TamResimYolu
            // 
            this.tb_TamResimYolu.Enabled = false;
            this.tb_TamResimYolu.Location = new System.Drawing.Point(163, 130);
            this.tb_TamResimYolu.Name = "tb_TamResimYolu";
            this.tb_TamResimYolu.Size = new System.Drawing.Size(167, 20);
            this.tb_TamResimYolu.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ürünün Açıklaması:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ürünün Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ürün Tam Resim Yolu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ürünün Yapımcısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ürünün Yayıncısı:";
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(163, 26);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(167, 20);
            this.tb_ID.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ürün ID:";
            // 
            // gb_DGV
            // 
            this.gb_DGV.Controls.Add(this.DGV_YoneticiView);
            this.gb_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_DGV.Location = new System.Drawing.Point(0, 238);
            this.gb_DGV.Name = "gb_DGV";
            this.gb_DGV.Size = new System.Drawing.Size(1016, 212);
            this.gb_DGV.TabIndex = 32;
            this.gb_DGV.TabStop = false;
            this.gb_DGV.Text = "Yönticiler:";
            // 
            // btn_IkonYolu
            // 
            this.btn_IkonYolu.Enabled = false;
            this.btn_IkonYolu.Location = new System.Drawing.Point(910, 24);
            this.btn_IkonYolu.Name = "btn_IkonYolu";
            this.btn_IkonYolu.Size = new System.Drawing.Size(94, 39);
            this.btn_IkonYolu.TabIndex = 56;
            this.btn_IkonYolu.Text = "Webde Gör";
            this.btn_IkonYolu.UseVisualStyleBackColor = true;
            this.btn_IkonYolu.Click += new System.EventHandler(this.btn_IkonYolu_Click);
            // 
            // cb_Yayinci
            // 
            this.cb_Yayinci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Yayinci.Enabled = false;
            this.cb_Yayinci.FormattingEnabled = true;
            this.cb_Yayinci.Location = new System.Drawing.Point(163, 52);
            this.cb_Yayinci.Name = "cb_Yayinci";
            this.cb_Yayinci.Size = new System.Drawing.Size(167, 21);
            this.cb_Yayinci.TabIndex = 55;
            // 
            // cb_Yapimci
            // 
            this.cb_Yapimci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Yapimci.Enabled = false;
            this.cb_Yapimci.FormattingEnabled = true;
            this.cb_Yapimci.Location = new System.Drawing.Point(163, 78);
            this.cb_Yapimci.Name = "cb_Yapimci";
            this.cb_Yapimci.Size = new System.Drawing.Size(167, 21);
            this.cb_Yapimci.TabIndex = 55;
            // 
            // btn_WebdeGor
            // 
            this.btn_WebdeGor.Enabled = false;
            this.btn_WebdeGor.Location = new System.Drawing.Point(163, 6);
            this.btn_WebdeGor.Name = "btn_WebdeGor";
            this.btn_WebdeGor.Size = new System.Drawing.Size(167, 20);
            this.btn_WebdeGor.TabIndex = 57;
            this.btn_WebdeGor.Text = "Ürünü Webde Gör";
            this.btn_WebdeGor.UseVisualStyleBackColor = true;
            this.btn_WebdeGor.Click += new System.EventHandler(this.btn_WebdeGor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ürünün Fiyatı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Ürünün İndirimi:";
            // 
            // nud_Fiyat
            // 
            this.nud_Fiyat.Enabled = false;
            this.nud_Fiyat.Location = new System.Drawing.Point(453, 183);
            this.nud_Fiyat.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nud_Fiyat.Name = "nud_Fiyat";
            this.nud_Fiyat.Size = new System.Drawing.Size(120, 20);
            this.nud_Fiyat.TabIndex = 58;
            // 
            // nud_Indirim
            // 
            this.nud_Indirim.Enabled = false;
            this.nud_Indirim.Location = new System.Drawing.Point(453, 209);
            this.nud_Indirim.Name = "nud_Indirim";
            this.nud_Indirim.Size = new System.Drawing.Size(120, 20);
            this.nud_Indirim.TabIndex = 58;
            // 
            // btn_ArkaPlanResimYolu
            // 
            this.btn_ArkaPlanResimYolu.Enabled = false;
            this.btn_ArkaPlanResimYolu.Location = new System.Drawing.Point(910, 116);
            this.btn_ArkaPlanResimYolu.Name = "btn_ArkaPlanResimYolu";
            this.btn_ArkaPlanResimYolu.Size = new System.Drawing.Size(94, 41);
            this.btn_ArkaPlanResimYolu.TabIndex = 48;
            this.btn_ArkaPlanResimYolu.Text = "Webde Gör";
            this.btn_ArkaPlanResimYolu.UseVisualStyleBackColor = true;
            this.btn_ArkaPlanResimYolu.Click += new System.EventHandler(this.btn_ArkaPlanResimYolu_Click);
            // 
            // UrunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.nud_Indirim);
            this.Controls.Add(this.nud_Fiyat);
            this.Controls.Add(this.btn_WebdeGor);
            this.Controls.Add(this.btn_IkonYolu);
            this.Controls.Add(this.cb_Yapimci);
            this.Controls.Add(this.cb_Yayinci);
            this.Controls.Add(this.tb_IkonYolu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Aktif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Error);
            this.Controls.Add(this.tb_ArkaPlanResimYolu);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ArkaPlanResimYolu);
            this.Controls.Add(this.btn_TamResimYolu);
            this.Controls.Add(this.tb_Aciklama);
            this.Controls.Add(this.tb_UrununAdi);
            this.Controls.Add(this.tb_TamResimYolu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_DGV);
            this.Name = "UrunPanel";
            this.Text = "UrunPanel";
            this.Load += new System.EventHandler(this.UrunPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_YoneticiView)).EndInit();
            this.gb_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Indirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_YoneticiView;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox tb_IkonYolu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Aktif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Error;
        private System.Windows.Forms.TextBox tb_ArkaPlanResimYolu;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_TamResimYolu;
        private System.Windows.Forms.TextBox tb_Aciklama;
        private System.Windows.Forms.TextBox tb_UrununAdi;
        private System.Windows.Forms.TextBox tb_TamResimYolu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_DGV;
        private System.Windows.Forms.Button btn_IkonYolu;
        private System.Windows.Forms.ComboBox cb_Yayinci;
        private System.Windows.Forms.ComboBox cb_Yapimci;
        private System.Windows.Forms.Button btn_WebdeGor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_Fiyat;
        private System.Windows.Forms.NumericUpDown nud_Indirim;
        private System.Windows.Forms.Button btn_ArkaPlanResimYolu;
    }
}