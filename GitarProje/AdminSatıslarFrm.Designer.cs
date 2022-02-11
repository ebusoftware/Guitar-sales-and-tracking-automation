
namespace GitarProje
{
    partial class AdminSatıslarFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSatıslarFrm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TxtTarih = new System.Windows.Forms.TextBox();
            this.TxtAdet = new System.Windows.Forms.TextBox();
            this.TxtBrFiyat = new System.Windows.Forms.TextBox();
            this.TxtMusteriİD = new System.Windows.Forms.TextBox();
            this.TxtUrunİD = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIleri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.BtnIlk = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSatisİD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisİD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(894, 402);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TxtTarih);
            this.groupControl2.Controls.Add(this.TxtAdet);
            this.groupControl2.Controls.Add(this.TxtBrFiyat);
            this.groupControl2.Controls.Add(this.TxtMusteriİD);
            this.groupControl2.Controls.Add(this.TxtUrunİD);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.BtnSon);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.BtnIleri);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.BtnGeri);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.BtnIlk);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.TxtSatisİD);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(900, 2);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(509, 402);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Ürün No:";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(89, 245);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(140, 21);
            this.TxtTarih.TabIndex = 38;
            // 
            // TxtAdet
            // 
            this.TxtAdet.Location = new System.Drawing.Point(89, 207);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(140, 21);
            this.TxtAdet.TabIndex = 38;
            // 
            // TxtBrFiyat
            // 
            this.TxtBrFiyat.Location = new System.Drawing.Point(89, 169);
            this.TxtBrFiyat.Name = "TxtBrFiyat";
            this.TxtBrFiyat.Size = new System.Drawing.Size(140, 21);
            this.TxtBrFiyat.TabIndex = 38;
            // 
            // TxtMusteriİD
            // 
            this.TxtMusteriİD.Location = new System.Drawing.Point(89, 131);
            this.TxtMusteriİD.Name = "TxtMusteriİD";
            this.TxtMusteriİD.Size = new System.Drawing.Size(140, 21);
            this.TxtMusteriİD.TabIndex = 38;
            // 
            // TxtUrunİD
            // 
            this.TxtUrunİD.Location = new System.Drawing.Point(89, 93);
            this.TxtUrunİD.Name = "TxtUrunİD";
            this.TxtUrunİD.Size = new System.Drawing.Size(140, 21);
            this.TxtUrunİD.TabIndex = 38;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(389, 306);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(91, 42);
            this.simpleButton4.TabIndex = 37;
            this.simpleButton4.Text = "TEMİZLE";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(280, 306);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(91, 42);
            this.simpleButton3.TabIndex = 37;
            this.simpleButton3.Text = "GÜNCELLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(159, 306);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(91, 42);
            this.simpleButton2.TabIndex = 37;
            this.simpleButton2.Text = "SİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(31, 306);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(91, 42);
            this.simpleButton1.TabIndex = 37;
            this.simpleButton1.Text = "KAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "SON KAYIT";
            // 
            // BtnSon
            // 
            this.BtnSon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSon.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSon.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSon.Location = new System.Drawing.Point(433, 70);
            this.BtnSon.Name = "BtnSon";
            this.BtnSon.Size = new System.Drawing.Size(50, 26);
            this.BtnSon.TabIndex = 21;
            this.BtnSon.Text = ">>>";
            this.BtnSon.UseVisualStyleBackColor = false;
            this.BtnSon.Click += new System.EventHandler(this.BtnSon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(385, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "İLERİ";
            // 
            // BtnIleri
            // 
            this.BtnIleri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnIleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnIleri.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIleri.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIleri.Location = new System.Drawing.Point(389, 70);
            this.BtnIleri.Name = "BtnIleri";
            this.BtnIleri.Size = new System.Drawing.Size(22, 26);
            this.BtnIleri.TabIndex = 19;
            this.BtnIleri.Text = ">";
            this.BtnIleri.UseVisualStyleBackColor = false;
            this.BtnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "GERİ";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGeri.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGeri.Location = new System.Drawing.Point(345, 70);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(20, 26);
            this.BtnGeri.TabIndex = 17;
            this.BtnGeri.Text = "<";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(49, 245);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 17);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "İLK KAYIT";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(51, 207);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 17);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Adet:";
            // 
            // BtnIlk
            // 
            this.BtnIlk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnIlk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnIlk.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnIlk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIlk.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIlk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIlk.Location = new System.Drawing.Point(280, 70);
            this.BtnIlk.Name = "BtnIlk";
            this.BtnIlk.Size = new System.Drawing.Size(46, 26);
            this.BtnIlk.TabIndex = 15;
            this.BtnIlk.Text = "<<<";
            this.BtnIlk.UseVisualStyleBackColor = false;
            this.BtnIlk.Click += new System.EventHandler(this.BtnIlk_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 169);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 17);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Birim Fiyat:";
            // 
            // TxtSatisİD
            // 
            this.TxtSatisİD.Location = new System.Drawing.Point(89, 35);
            this.TxtSatisİD.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSatisİD.Name = "TxtSatisİD";
            this.TxtSatisİD.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatisİD.Properties.Appearance.Options.UseFont = true;
            this.TxtSatisİD.Size = new System.Drawing.Size(140, 24);
            this.TxtSatisİD.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 131);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Muşteri İD:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 38);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Satış İD:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 93);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ürün İD:";
            // 
            // AdminSatıslarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 405);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "AdminSatıslarFrm";
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.AdminSatıslarFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisİD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox TxtUrunİD;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIlk;
        public DevExpress.XtraEditors.TextEdit TxtSatisİD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox TxtTarih;
        private System.Windows.Forms.TextBox TxtAdet;
        private System.Windows.Forms.TextBox TxtBrFiyat;
        private System.Windows.Forms.TextBox TxtMusteriİD;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}