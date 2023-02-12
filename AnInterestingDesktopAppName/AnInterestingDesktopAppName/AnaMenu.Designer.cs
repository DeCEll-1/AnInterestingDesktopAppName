namespace AnInterestingDesktopAppName
{
    partial class AnaMenu
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
            this.sstrp_1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Pusher = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.TSMI_Yonetici = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIYonetici = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIFirma = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIUrun = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIKullanici = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIOyunFotograflari = new System.Windows.Forms.ToolStripMenuItem();
            this.sstrp_1.SuspendLayout();
            this.ms_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sstrp_1
            // 
            this.sstrp_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Pusher,
            this.tssl_Name});
            this.sstrp_1.Location = new System.Drawing.Point(0, 428);
            this.sstrp_1.Name = "sstrp_1";
            this.sstrp_1.Size = new System.Drawing.Size(800, 22);
            this.sstrp_1.TabIndex = 1;
            // 
            // tssl_Pusher
            // 
            this.tssl_Pusher.Name = "tssl_Pusher";
            this.tssl_Pusher.Size = new System.Drawing.Size(0, 17);
            // 
            // tssl_Name
            // 
            this.tssl_Name.Name = "tssl_Name";
            this.tssl_Name.Size = new System.Drawing.Size(0, 17);
            // 
            // ms_MenuStrip
            // 
            this.ms_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Yonetici});
            this.ms_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ms_MenuStrip.Name = "ms_MenuStrip";
            this.ms_MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.ms_MenuStrip.TabIndex = 2;
            this.ms_MenuStrip.Text = "menuStrip1";
            // 
            // TSMI_Yonetici
            // 
            this.TSMI_Yonetici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIYonetici,
            this.TSMIFirma,
            this.TSMIUrun,
            this.TSMIKullanici,
            this.TSMIOyunFotograflari});
            this.TSMI_Yonetici.Name = "TSMI_Yonetici";
            this.TSMI_Yonetici.Size = new System.Drawing.Size(61, 20);
            this.TSMI_Yonetici.Text = "Paneller";
            // 
            // TSMIYonetici
            // 
            this.TSMIYonetici.Name = "TSMIYonetici";
            this.TSMIYonetici.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.TSMIYonetici.Size = new System.Drawing.Size(229, 22);
            this.TSMIYonetici.Text = "Yönetici Paneli";
            this.TSMIYonetici.Click += new System.EventHandler(this.TSMIYonetici_Click);
            // 
            // TSMIFirma
            // 
            this.TSMIFirma.Name = "TSMIFirma";
            this.TSMIFirma.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.TSMIFirma.Size = new System.Drawing.Size(229, 22);
            this.TSMIFirma.Text = "Firma Paneli";
            this.TSMIFirma.Click += new System.EventHandler(this.TSMIFirma_Click);
            // 
            // TSMIUrun
            // 
            this.TSMIUrun.Name = "TSMIUrun";
            this.TSMIUrun.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.TSMIUrun.Size = new System.Drawing.Size(229, 22);
            this.TSMIUrun.Text = "Ürün Paneli";
            this.TSMIUrun.Click += new System.EventHandler(this.TSMIUrun_Click);
            // 
            // TSMIKullanici
            // 
            this.TSMIKullanici.Name = "TSMIKullanici";
            this.TSMIKullanici.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.TSMIKullanici.Size = new System.Drawing.Size(229, 22);
            this.TSMIKullanici.Text = "Kullanıcı Paneli";
            this.TSMIKullanici.Click += new System.EventHandler(this.TSMIKullanici_Click);
            // 
            // TSMIOyunFotograflari
            // 
            this.TSMIOyunFotograflari.Name = "TSMIOyunFotograflari";
            this.TSMIOyunFotograflari.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMIOyunFotograflari.Size = new System.Drawing.Size(229, 22);
            this.TSMIOyunFotograflari.Text = "Oyun Fotoğraf Paneli";
            this.TSMIOyunFotograflari.Click += new System.EventHandler(this.oyunFotoğrafPaneliToolStripMenuItem_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sstrp_1);
            this.Controls.Add(this.ms_MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_MenuStrip;
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.sstrp_1.ResumeLayout(false);
            this.sstrp_1.PerformLayout();
            this.ms_MenuStrip.ResumeLayout(false);
            this.ms_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sstrp_1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Name;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Pusher;
        private System.Windows.Forms.MenuStrip ms_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Yonetici;
        private System.Windows.Forms.ToolStripMenuItem TSMIYonetici;
        private System.Windows.Forms.ToolStripMenuItem TSMIFirma;
        private System.Windows.Forms.ToolStripMenuItem TSMIUrun;
        private System.Windows.Forms.ToolStripMenuItem TSMIKullanici;
        private System.Windows.Forms.ToolStripMenuItem TSMIOyunFotograflari;
    }
}