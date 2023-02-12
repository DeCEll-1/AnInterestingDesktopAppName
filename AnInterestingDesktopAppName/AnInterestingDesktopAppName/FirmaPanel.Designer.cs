namespace AnInterestingDesktopAppName
{
    partial class FirmaPanel
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
            this.DGV_FirmaView = new System.Windows.Forms.DataGridView();
            this.gb_DGV = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_FirmaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_FirmaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_FirmaHakkinda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_FirmaResmi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_FirmaArkaPlanResmi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_FirmaMail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_FirmaArkaPlanResmiLink = new System.Windows.Forms.Button();
            this.btn_FirmaResmiLink = new System.Windows.Forms.Button();
            this.btn_SeeCompany = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Error = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Aktif = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FirmaView)).BeginInit();
            this.gb_DGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_FirmaView
            // 
            this.DGV_FirmaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_FirmaView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_FirmaView.Location = new System.Drawing.Point(3, 16);
            this.DGV_FirmaView.Name = "DGV_FirmaView";
            this.DGV_FirmaView.ReadOnly = true;
            this.DGV_FirmaView.Size = new System.Drawing.Size(794, 193);
            this.DGV_FirmaView.TabIndex = 0;
            this.DGV_FirmaView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_FirmaView_CellClick_1);
            // 
            // gb_DGV
            // 
            this.gb_DGV.Controls.Add(this.DGV_FirmaView);
            this.gb_DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_DGV.Location = new System.Drawing.Point(0, 238);
            this.gb_DGV.Name = "gb_DGV";
            this.gb_DGV.Size = new System.Drawing.Size(800, 212);
            this.gb_DGV.TabIndex = 1;
            this.gb_DGV.TabStop = false;
            this.gb_DGV.Text = "Firmalar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firma ID:";
            // 
            // tb_FirmaID
            // 
            this.tb_FirmaID.Enabled = false;
            this.tb_FirmaID.Location = new System.Drawing.Point(190, 32);
            this.tb_FirmaID.Name = "tb_FirmaID";
            this.tb_FirmaID.Size = new System.Drawing.Size(167, 20);
            this.tb_FirmaID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma Adı:";
            // 
            // tb_FirmaAdi
            // 
            this.tb_FirmaAdi.Location = new System.Drawing.Point(190, 58);
            this.tb_FirmaAdi.Name = "tb_FirmaAdi";
            this.tb_FirmaAdi.Size = new System.Drawing.Size(167, 20);
            this.tb_FirmaAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firma Hakkında:";
            // 
            // tb_FirmaHakkinda
            // 
            this.tb_FirmaHakkinda.Enabled = false;
            this.tb_FirmaHakkinda.Location = new System.Drawing.Point(190, 84);
            this.tb_FirmaHakkinda.Name = "tb_FirmaHakkinda";
            this.tb_FirmaHakkinda.Size = new System.Drawing.Size(167, 20);
            this.tb_FirmaHakkinda.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Firma Resmi:";
            // 
            // tb_FirmaResmi
            // 
            this.tb_FirmaResmi.Enabled = false;
            this.tb_FirmaResmi.Location = new System.Drawing.Point(190, 110);
            this.tb_FirmaResmi.Name = "tb_FirmaResmi";
            this.tb_FirmaResmi.Size = new System.Drawing.Size(167, 20);
            this.tb_FirmaResmi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Firma ArkaPlan Resmi:";
            // 
            // tb_FirmaArkaPlanResmi
            // 
            this.tb_FirmaArkaPlanResmi.Enabled = false;
            this.tb_FirmaArkaPlanResmi.Location = new System.Drawing.Point(190, 136);
            this.tb_FirmaArkaPlanResmi.Name = "tb_FirmaArkaPlanResmi";
            this.tb_FirmaArkaPlanResmi.Size = new System.Drawing.Size(167, 20);
            this.tb_FirmaArkaPlanResmi.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Firma Maili:";
            // 
            // tb_FirmaMail
            // 
            this.tb_FirmaMail.Location = new System.Drawing.Point(190, 162);
            this.tb_FirmaMail.Name = "tb_FirmaMail";
            this.tb_FirmaMail.Size = new System.Drawing.Size(167, 20);
            this.tb_FirmaMail.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(355, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 150);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_FirmaArkaPlanResmiLink
            // 
            this.btn_FirmaArkaPlanResmiLink.Enabled = false;
            this.btn_FirmaArkaPlanResmiLink.Location = new System.Drawing.Point(694, 77);
            this.btn_FirmaArkaPlanResmiLink.Name = "btn_FirmaArkaPlanResmiLink";
            this.btn_FirmaArkaPlanResmiLink.Size = new System.Drawing.Size(94, 39);
            this.btn_FirmaArkaPlanResmiLink.TabIndex = 4;
            this.btn_FirmaArkaPlanResmiLink.Text = "Webde Gör";
            this.btn_FirmaArkaPlanResmiLink.UseVisualStyleBackColor = true;
            this.btn_FirmaArkaPlanResmiLink.Click += new System.EventHandler(this.btn_FirmaArkaPlanResmiLink_Click);
            // 
            // btn_FirmaResmiLink
            // 
            this.btn_FirmaResmiLink.Enabled = false;
            this.btn_FirmaResmiLink.Location = new System.Drawing.Point(694, 32);
            this.btn_FirmaResmiLink.Name = "btn_FirmaResmiLink";
            this.btn_FirmaResmiLink.Size = new System.Drawing.Size(94, 39);
            this.btn_FirmaResmiLink.TabIndex = 4;
            this.btn_FirmaResmiLink.Text = "Webde Gör";
            this.btn_FirmaResmiLink.UseVisualStyleBackColor = true;
            this.btn_FirmaResmiLink.Click += new System.EventHandler(this.btn_FirmaResmiLink_Click);
            // 
            // btn_SeeCompany
            // 
            this.btn_SeeCompany.Enabled = false;
            this.btn_SeeCompany.Location = new System.Drawing.Point(190, 12);
            this.btn_SeeCompany.Name = "btn_SeeCompany";
            this.btn_SeeCompany.Size = new System.Drawing.Size(94, 20);
            this.btn_SeeCompany.TabIndex = 6;
            this.btn_SeeCompany.Text = "Firmayı Webde Gör";
            this.btn_SeeCompany.UseVisualStyleBackColor = true;
            this.btn_SeeCompany.Click += new System.EventHandler(this.btn_SeeCompany_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(255, 188);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 44);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Error
            // 
            this.btn_Error.Enabled = false;
            this.btn_Error.Location = new System.Drawing.Point(363, 188);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.Size = new System.Drawing.Size(325, 44);
            this.btn_Error.TabIndex = 7;
            this.btn_Error.UseVisualStyleBackColor = true;
            this.btn_Error.Visible = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(29, 12);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(94, 20);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "Seçimi Sıfırla";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Aktif
            // 
            this.btn_Aktif.Location = new System.Drawing.Point(694, 122);
            this.btn_Aktif.Name = "btn_Aktif";
            this.btn_Aktif.Size = new System.Drawing.Size(94, 110);
            this.btn_Aktif.TabIndex = 8;
            this.btn_Aktif.Text = "Silinenleri Göster\t";
            this.btn_Aktif.UseVisualStyleBackColor = true;
            this.btn_Aktif.Click += new System.EventHandler(this.btn_Aktif_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.Location = new System.Drawing.Point(190, 188);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(59, 44);
            this.btn_Sil.TabIndex = 9;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // FirmaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Aktif);
            this.Controls.Add(this.btn_Error);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_SeeCompany);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_FirmaResmiLink);
            this.Controls.Add(this.btn_FirmaArkaPlanResmiLink);
            this.Controls.Add(this.tb_FirmaMail);
            this.Controls.Add(this.tb_FirmaArkaPlanResmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_FirmaResmi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_FirmaHakkinda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_FirmaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_FirmaID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FirmaPanel";
            this.Text = "FirmaPanel";
            this.Load += new System.EventHandler(this.FirmaPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FirmaView)).EndInit();
            this.gb_DGV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_FirmaView;
        private System.Windows.Forms.GroupBox gb_DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_FirmaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_FirmaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_FirmaHakkinda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_FirmaResmi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_FirmaArkaPlanResmi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_FirmaMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_FirmaArkaPlanResmiLink;
        private System.Windows.Forms.Button btn_FirmaResmiLink;
        private System.Windows.Forms.Button btn_SeeCompany;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Error;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Aktif;
        private System.Windows.Forms.Button btn_Sil;
    }
}