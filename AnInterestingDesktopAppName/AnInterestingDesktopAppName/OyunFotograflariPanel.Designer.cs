namespace AnInterestingDesktopAppName
{
    partial class OyunFotograflariPanel
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
            this.cb_Urun = new System.Windows.Forms.ComboBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Aktif = new System.Windows.Forms.Button();
            this.btn_Error = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_DGV = new System.Windows.Forms.GroupBox();
            this.DGV_YoneticiView = new System.Windows.Forms.DataGridView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_ProfilResmi = new System.Windows.Forms.Button();
            this.tb_UrunID = new System.Windows.Forms.TextBox();
            this.tb_FotografYolu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_YoneticiView)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Urun
            // 
            this.cb_Urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Urun.FormattingEnabled = true;
            this.cb_Urun.Location = new System.Drawing.Point(163, 52);
            this.cb_Urun.Name = "cb_Urun";
            this.cb_Urun.Size = new System.Drawing.Size(167, 21);
            this.cb_Urun.TabIndex = 55;
            this.cb_Urun.SelectedIndexChanged += new System.EventHandler(this.cb_Urun_SelectedIndexChanged);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.Location = new System.Drawing.Point(336, 185);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(56, 41);
            this.btn_Sil.TabIndex = 54;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Aktif
            // 
            this.btn_Aktif.Location = new System.Drawing.Point(544, 118);
            this.btn_Aktif.Name = "btn_Aktif";
            this.btn_Aktif.Size = new System.Drawing.Size(94, 108);
            this.btn_Aktif.TabIndex = 53;
            this.btn_Aktif.Text = "Silinenleri Göster\t";
            this.btn_Aktif.UseVisualStyleBackColor = true;
            this.btn_Aktif.Click += new System.EventHandler(this.btn_Aktif_Click);
            // 
            // btn_Error
            // 
            this.btn_Error.Enabled = false;
            this.btn_Error.Location = new System.Drawing.Point(398, 182);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.Size = new System.Drawing.Size(140, 44);
            this.btn_Error.TabIndex = 52;
            this.btn_Error.UseVisualStyleBackColor = true;
            this.btn_Error.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(328, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 150);
            this.panel1.TabIndex = 49;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ürün ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Seçilen Ürün:";
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
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fotoğraf ID:";
            // 
            // gb_DGV
            // 
            this.gb_DGV.Controls.Add(this.DGV_YoneticiView);
            this.gb_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_DGV.Location = new System.Drawing.Point(0, 238);
            this.gb_DGV.Name = "gb_DGV";
            this.gb_DGV.Size = new System.Drawing.Size(642, 212);
            this.gb_DGV.TabIndex = 32;
            this.gb_DGV.TabStop = false;
            this.gb_DGV.Text = "Fotoğraflar:";
            // 
            // DGV_YoneticiView
            // 
            this.DGV_YoneticiView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_YoneticiView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_YoneticiView.Location = new System.Drawing.Point(3, 16);
            this.DGV_YoneticiView.Name = "DGV_YoneticiView";
            this.DGV_YoneticiView.ReadOnly = true;
            this.DGV_YoneticiView.Size = new System.Drawing.Size(636, 193);
            this.DGV_YoneticiView.TabIndex = 0;
            this.DGV_YoneticiView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_YoneticiView_CellClick);
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
            // btn_ProfilResmi
            // 
            this.btn_ProfilResmi.Enabled = false;
            this.btn_ProfilResmi.Location = new System.Drawing.Point(544, 26);
            this.btn_ProfilResmi.Name = "btn_ProfilResmi";
            this.btn_ProfilResmi.Size = new System.Drawing.Size(94, 41);
            this.btn_ProfilResmi.TabIndex = 48;
            this.btn_ProfilResmi.Text = "Webde Gör";
            this.btn_ProfilResmi.UseVisualStyleBackColor = true;
            this.btn_ProfilResmi.Click += new System.EventHandler(this.btn_ProfilResmi_Click);
            // 
            // tb_UrunID
            // 
            this.tb_UrunID.Enabled = false;
            this.tb_UrunID.Location = new System.Drawing.Point(163, 78);
            this.tb_UrunID.Name = "tb_UrunID";
            this.tb_UrunID.Size = new System.Drawing.Size(167, 20);
            this.tb_UrunID.TabIndex = 41;
            // 
            // tb_FotografYolu
            // 
            this.tb_FotografYolu.Enabled = false;
            this.tb_FotografYolu.Location = new System.Drawing.Point(163, 104);
            this.tb_FotografYolu.Name = "tb_FotografYolu";
            this.tb_FotografYolu.Size = new System.Drawing.Size(167, 20);
            this.tb_FotografYolu.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fotoğraf Yolu:";
            // 
            // OyunFotograflariPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.cb_Urun);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Aktif);
            this.Controls.Add(this.btn_Error);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_DGV);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_ProfilResmi);
            this.Controls.Add(this.tb_FotografYolu);
            this.Controls.Add(this.tb_UrunID);
            this.Name = "OyunFotograflariPanel";
            this.Text = "OyunFotograflariPanel";
            this.Load += new System.EventHandler(this.OyunFotograflariPanel_Load);
            this.gb_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_YoneticiView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Urun;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Aktif;
        private System.Windows.Forms.Button btn_Error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_DGV;
        private System.Windows.Forms.DataGridView DGV_YoneticiView;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_ProfilResmi;
        private System.Windows.Forms.TextBox tb_UrunID;
        private System.Windows.Forms.TextBox tb_FotografYolu;
        private System.Windows.Forms.Label label3;
    }
}