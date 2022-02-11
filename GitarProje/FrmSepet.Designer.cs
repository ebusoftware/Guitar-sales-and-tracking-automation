
namespace GitarProje
{
    partial class FrmSepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSepet));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnUrnSil = new System.Windows.Forms.Button();
            this.BtnOde = new System.Windows.Forms.Button();
            this.RchAdet = new System.Windows.Forms.RichTextBox();
            this.RchUrunAdi = new System.Windows.Forms.RichTextBox();
            this.RchBirimFiyat = new System.Windows.Forms.RichTextBox();
            this.RchTutar = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(486, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 27);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürün Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(633, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 27);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Adet";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(731, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 27);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Birim Fiyat";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(881, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 27);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Tutar";
            // 
            // BtnUrnSil
            // 
            this.BtnUrnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnUrnSil.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnUrnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUrnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrnSil.ForeColor = System.Drawing.Color.Crimson;
            this.BtnUrnSil.Location = new System.Drawing.Point(987, 45);
            this.BtnUrnSil.Name = "BtnUrnSil";
            this.BtnUrnSil.Size = new System.Drawing.Size(102, 42);
            this.BtnUrnSil.TabIndex = 2;
            this.BtnUrnSil.Text = "Ürün Sil";
            this.BtnUrnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnUrnSil.UseVisualStyleBackColor = false;
            // 
            // BtnOde
            // 
            this.BtnOde.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnOde.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnOde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOde.ForeColor = System.Drawing.Color.Crimson;
            this.BtnOde.Location = new System.Drawing.Point(987, 340);
            this.BtnOde.Name = "BtnOde";
            this.BtnOde.Size = new System.Drawing.Size(102, 42);
            this.BtnOde.TabIndex = 2;
            this.BtnOde.Text = "ÖDEME";
            this.BtnOde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnOde.UseVisualStyleBackColor = false;
            this.BtnOde.Click += new System.EventHandler(this.BtnOde_Click);
            // 
            // RchAdet
            // 
            this.RchAdet.Location = new System.Drawing.Point(593, 45);
            this.RchAdet.Name = "RchAdet";
            this.RchAdet.Size = new System.Drawing.Size(119, 257);
            this.RchAdet.TabIndex = 3;
            this.RchAdet.Text = "";
            // 
            // RchUrunAdi
            // 
            this.RchUrunAdi.Location = new System.Drawing.Point(449, 45);
            this.RchUrunAdi.Name = "RchUrunAdi";
            this.RchUrunAdi.Size = new System.Drawing.Size(138, 257);
            this.RchUrunAdi.TabIndex = 4;
            this.RchUrunAdi.Text = "";
            // 
            // RchBirimFiyat
            // 
            this.RchBirimFiyat.Location = new System.Drawing.Point(718, 45);
            this.RchBirimFiyat.Name = "RchBirimFiyat";
            this.RchBirimFiyat.Size = new System.Drawing.Size(129, 257);
            this.RchBirimFiyat.TabIndex = 3;
            this.RchBirimFiyat.Text = "";
            // 
            // RchTutar
            // 
            this.RchTutar.Location = new System.Drawing.Point(853, 45);
            this.RchTutar.Name = "RchTutar";
            this.RchTutar.Size = new System.Drawing.Size(128, 257);
            this.RchTutar.TabIndex = 3;
            this.RchTutar.Text = "";
            this.RchTutar.TextChanged += new System.EventHandler(this.RchTutar_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sepeti Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RchUrunAdi);
            this.Controls.Add(this.RchTutar);
            this.Controls.Add(this.RchBirimFiyat);
            this.Controls.Add(this.RchAdet);
            this.Controls.Add(this.BtnOde);
            this.Controls.Add(this.BtnUrnSil);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmSepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.FrmSepet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button BtnUrnSil;
        private System.Windows.Forms.Button BtnOde;
        private System.Windows.Forms.RichTextBox RchAdet;
        private System.Windows.Forms.RichTextBox RchUrunAdi;
        private System.Windows.Forms.RichTextBox RchBirimFiyat;
        private System.Windows.Forms.RichTextBox RchTutar;
        private System.Windows.Forms.Button button1;
    }
}