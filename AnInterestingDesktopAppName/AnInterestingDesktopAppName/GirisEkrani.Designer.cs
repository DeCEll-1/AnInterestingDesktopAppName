namespace AnInterestingDesktopAppName
{
    partial class GirisEkrani
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
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Error = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(53, 12);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(169, 20);
            this.tb_Mail.TabIndex = 1;
            this.tb_Mail.Text = "poedx2@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mail:";
            // 
            // tb_Sifre
            // 
            this.tb_Sifre.Location = new System.Drawing.Point(53, 38);
            this.tb_Sifre.Name = "tb_Sifre";
            this.tb_Sifre.Size = new System.Drawing.Size(169, 20);
            this.tb_Sifre.TabIndex = 2;
            this.tb_Sifre.Text = "123456789";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(133, 64);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(90, 35);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Giriş";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Error
            // 
            this.btn_Error.Enabled = false;
            this.btn_Error.Location = new System.Drawing.Point(12, 64);
            this.btn_Error.Name = "btn_Error";
            this.btn_Error.Size = new System.Drawing.Size(115, 35);
            this.btn_Error.TabIndex = 3;
            this.btn_Error.UseVisualStyleBackColor = true;
            this.btn_Error.Visible = false;
            // 
            // GirisEkrani
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.btn_Error);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Sifre);
            this.Controls.Add(this.tb_Mail);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GirisEkrani_FormClosed);
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Error;
    }
}