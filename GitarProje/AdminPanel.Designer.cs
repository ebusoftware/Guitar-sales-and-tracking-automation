
namespace GitarProje
{
    partial class AdminGirisPanelFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGirisPanelFrm));
            this.TxtKadi = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAnasayfa = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnKullaniciEkle = new System.Windows.Forms.Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtKadi
            // 
            this.TxtKadi.Location = new System.Drawing.Point(416, 76);
            this.TxtKadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtKadi.Name = "TxtKadi";
            this.TxtKadi.Size = new System.Drawing.Size(156, 22);
            this.TxtKadi.TabIndex = 0;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(416, 125);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(156, 22);
            this.TxtSifre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(271, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(342, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("News706 BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(429, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "GİRİŞ";
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.BackColor = System.Drawing.Color.Red;
            this.BtnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnasayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAnasayfa.Location = new System.Drawing.Point(12, 385);
            this.BtnAnasayfa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            this.BtnAnasayfa.Size = new System.Drawing.Size(139, 62);
            this.BtnAnasayfa.TabIndex = 3;
            this.BtnAnasayfa.Text = "Anasayfa";
            this.BtnAnasayfa.UseVisualStyleBackColor = false;
            this.BtnAnasayfa.Click += new System.EventHandler(this.BtnAnasayfa_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Red;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(330, 192);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(275, 68);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCikis.Image = ((System.Drawing.Image)(resources.GetObject("BtnCikis.Image")));
            this.BtnCikis.Location = new System.Drawing.Point(541, 398);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(97, 50);
            this.BtnCikis.TabIndex = 3;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnKullaniciEkle
            // 
            this.BtnKullaniciEkle.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnKullaniciEkle.Location = new System.Drawing.Point(416, 280);
            this.BtnKullaniciEkle.Name = "BtnKullaniciEkle";
            this.BtnKullaniciEkle.Size = new System.Drawing.Size(110, 48);
            this.BtnKullaniciEkle.TabIndex = 4;
            this.BtnKullaniciEkle.Text = "Yeni Admin Ekle";
            this.BtnKullaniciEkle.UseVisualStyleBackColor = false;
            this.BtnKullaniciEkle.Click += new System.EventHandler(this.BtnKullaniciEkle_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 35);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(211, 202);
            this.pictureEdit1.TabIndex = 5;
            // 
            // AdminGirisPanelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 455);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.BtnKullaniciEkle);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnAnasayfa);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKadi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminGirisPanelFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminGirisPanelFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKadi;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnAnasayfa;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnKullaniciEkle;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}