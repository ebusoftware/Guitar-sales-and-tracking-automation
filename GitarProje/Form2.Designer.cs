
namespace GitarProje
{
    partial class FrmYeniKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKullanici));
            this.BtnAnasayfa = new System.Windows.Forms.Button();
            this.BtnKullaniciEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.BackColor = System.Drawing.Color.Red;
            this.BtnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnasayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAnasayfa.Location = new System.Drawing.Point(18, 382);
            this.BtnAnasayfa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            this.BtnAnasayfa.Size = new System.Drawing.Size(139, 62);
            this.BtnAnasayfa.TabIndex = 10;
            this.BtnAnasayfa.Text = "Anasayfa";
            this.BtnAnasayfa.UseVisualStyleBackColor = false;
            this.BtnAnasayfa.Click += new System.EventHandler(this.BtnAnasayfa_Click);
            // 
            // BtnKullaniciEkle
            // 
            this.BtnKullaniciEkle.BackColor = System.Drawing.Color.Green;
            this.BtnKullaniciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKullaniciEkle.ForeColor = System.Drawing.Color.White;
            this.BtnKullaniciEkle.Location = new System.Drawing.Point(317, 223);
            this.BtnKullaniciEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKullaniciEkle.Name = "BtnKullaniciEkle";
            this.BtnKullaniciEkle.Size = new System.Drawing.Size(183, 54);
            this.BtnKullaniciEkle.TabIndex = 11;
            this.BtnKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.BtnKullaniciEkle.UseVisualStyleBackColor = false;
            this.BtnKullaniciEkle.Click += new System.EventHandler(this.BtnKullaniciEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(273, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("News706 BT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(237, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Admin Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(216, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(343, 161);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(156, 22);
            this.TxtSifre.TabIndex = 4;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(343, 122);
            this.TxtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(156, 22);
            this.TxtKullaniciAdi.TabIndex = 5;
            // 
            // BtnCikis
            // 
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCikis.Image = ((System.Drawing.Image)(resources.GetObject("BtnCikis.Image")));
            this.BtnCikis.Location = new System.Drawing.Point(548, 394);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(97, 50);
            this.BtnCikis.TabIndex = 9;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(227, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adı Soyadı:";
            // 
            // TxtAdiSoyadi
            // 
            this.TxtAdiSoyadi.Location = new System.Drawing.Point(343, 77);
            this.TxtAdiSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAdiSoyadi.Name = "TxtAdiSoyadi";
            this.TxtAdiSoyadi.Size = new System.Drawing.Size(156, 22);
            this.TxtAdiSoyadi.TabIndex = 12;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 77);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(198, 181);
            this.pictureEdit1.TabIndex = 14;
            // 
            // FrmYeniKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 471);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAdiSoyadi);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnAnasayfa);
            this.Controls.Add(this.BtnKullaniciEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmYeniKullanici";
            this.Text = "Yeni Kullanıcı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnAnasayfa;
        private System.Windows.Forms.Button BtnKullaniciEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdiSoyadi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}