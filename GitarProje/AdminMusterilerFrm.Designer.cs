
namespace GitarProje
{
    partial class AdminMusterilerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMusterilerFrm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEposta = new DevExpress.XtraEditors.TextEdit();
            this.TxtVergiNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtGsmNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIleri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIlk = new System.Windows.Forms.Button();
            this.TxtİD = new DevExpress.XtraEditors.TextEdit();
            this.TxtSehirİD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGsmNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtİD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSehirİD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(899, 443);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged_1);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xtraTabControl1.Location = new System.Drawing.Point(906, 2);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(512, 443);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(510, 399);
            this.xtraTabPage1.Text = "Müşteri Bilgisi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.RchAdres);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.TxtAdi);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.TxtEposta);
            this.groupControl2.Controls.Add(this.TxtVergiNo);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.TxtGsmNo);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Controls.Add(this.TxtSoyadi);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.BtnSon);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.BtnIleri);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.BtnGeri);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.BtnIlk);
            this.groupControl2.Controls.Add(this.TxtİD);
            this.groupControl2.Controls.Add(this.TxtSehirİD);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(-1, 2);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(509, 409);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Ürün No:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(25, 312);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 17);
            this.labelControl6.TabIndex = 40;
            this.labelControl6.Text = "Adres";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(384, 348);
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
            this.simpleButton3.Location = new System.Drawing.Point(384, 301);
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
            this.simpleButton2.Location = new System.Drawing.Point(387, 237);
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
            this.simpleButton1.Location = new System.Drawing.Point(387, 176);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(91, 42);
            this.simpleButton1.TabIndex = 37;
            this.simpleButton1.Text = "KAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TxtAdi
            // 
            this.TxtAdi.Location = new System.Drawing.Point(86, 91);
            this.TxtAdi.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtAdi.Size = new System.Drawing.Size(140, 24);
            this.TxtAdi.TabIndex = 34;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(55, 94);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(23, 17);
            this.labelControl14.TabIndex = 33;
            this.labelControl14.Text = "Adı:";
            // 
            // TxtEposta
            // 
            this.TxtEposta.Location = new System.Drawing.Point(86, 255);
            this.TxtEposta.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEposta.Name = "TxtEposta";
            this.TxtEposta.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEposta.Properties.Appearance.Options.UseFont = true;
            this.TxtEposta.Size = new System.Drawing.Size(140, 24);
            this.TxtEposta.TabIndex = 31;
            // 
            // TxtVergiNo
            // 
            this.TxtVergiNo.Location = new System.Drawing.Point(86, 214);
            this.TxtVergiNo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtVergiNo.Name = "TxtVergiNo";
            this.TxtVergiNo.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVergiNo.Properties.Appearance.Options.UseFont = true;
            this.TxtVergiNo.Size = new System.Drawing.Size(140, 24);
            this.TxtVergiNo.TabIndex = 31;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 258);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 17);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "E-posta:";
            // 
            // TxtGsmNo
            // 
            this.TxtGsmNo.Location = new System.Drawing.Point(86, 173);
            this.TxtGsmNo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGsmNo.Name = "TxtGsmNo";
            this.TxtGsmNo.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGsmNo.Properties.Appearance.Options.UseFont = true;
            this.TxtGsmNo.Size = new System.Drawing.Size(140, 24);
            this.TxtGsmNo.TabIndex = 32;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(25, 217);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(56, 17);
            this.labelControl15.TabIndex = 30;
            this.labelControl15.Text = "Vergi No:";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(13, 175);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(70, 17);
            this.labelControl16.TabIndex = 29;
            this.labelControl16.Text = "Telefon No:";
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Location = new System.Drawing.Point(86, 132);
            this.TxtSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyadi.Properties.Appearance.Options.UseFont = true;
            this.TxtSoyadi.Size = new System.Drawing.Size(140, 24);
            this.TxtSoyadi.TabIndex = 27;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(37, 135);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(46, 17);
            this.labelControl17.TabIndex = 25;
            this.labelControl17.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 46);
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
            this.BtnSon.Location = new System.Drawing.Point(428, 16);
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
            this.label1.Location = new System.Drawing.Point(380, 42);
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
            this.BtnIleri.Location = new System.Drawing.Point(384, 16);
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
            this.label3.Location = new System.Drawing.Point(337, 45);
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
            this.BtnGeri.Location = new System.Drawing.Point(340, 16);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(20, 26);
            this.BtnGeri.TabIndex = 17;
            this.BtnGeri.Text = "<";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "İLK KAYIT";
            // 
            // BtnIlk
            // 
            this.BtnIlk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnIlk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnIlk.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnIlk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIlk.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIlk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIlk.Location = new System.Drawing.Point(275, 16);
            this.BtnIlk.Name = "BtnIlk";
            this.BtnIlk.Size = new System.Drawing.Size(46, 26);
            this.BtnIlk.TabIndex = 15;
            this.BtnIlk.Text = "<<<";
            this.BtnIlk.UseVisualStyleBackColor = false;
            this.BtnIlk.Click += new System.EventHandler(this.BtnIlk_Click);
            // 
            // TxtİD
            // 
            this.TxtİD.Location = new System.Drawing.Point(86, 9);
            this.TxtİD.Margin = new System.Windows.Forms.Padding(2);
            this.TxtİD.Name = "TxtİD";
            this.TxtİD.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtİD.Properties.Appearance.Options.UseFont = true;
            this.TxtİD.Size = new System.Drawing.Size(140, 24);
            this.TxtİD.TabIndex = 8;
            // 
            // TxtSehirİD
            // 
            this.TxtSehirİD.Location = new System.Drawing.Point(86, 50);
            this.TxtSehirİD.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSehirİD.Name = "TxtSehirİD";
            this.TxtSehirİD.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSehirİD.Properties.Appearance.Options.UseFont = true;
            this.TxtSehirİD.Size = new System.Drawing.Size(140, 24);
            this.TxtSehirİD.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Müşteri İD:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 53);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Şehir İD:";
            // 
            // RchAdres
            // 
            this.RchAdres.Location = new System.Drawing.Point(86, 312);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(196, 71);
            this.RchAdres.TabIndex = 41;
            this.RchAdres.Text = "";
            // 
            // AdminMusterilerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 449);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "AdminMusterilerFrm";
            this.Text = "AdminMusterilerFrm";
            this.Load += new System.EventHandler(this.AdminMusterilerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGsmNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtİD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSehirİD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit TxtAdi;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit TxtEposta;
        private DevExpress.XtraEditors.TextEdit TxtVergiNo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtGsmNo;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit TxtSoyadi;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIlk;
        public DevExpress.XtraEditors.TextEdit TxtİD;
        public DevExpress.XtraEditors.TextEdit TxtSehirİD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox RchAdres;
    }
}