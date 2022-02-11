
namespace GitarProje
{
    partial class FrmKategoriler
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
            this.BtnIleri = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.BtnSon = new System.Windows.Forms.Button();
            this.BtnIlk = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIleri
            // 
            this.BtnIleri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnIleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnIleri.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIleri.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIleri.Location = new System.Drawing.Point(799, 198);
            this.BtnIleri.Name = "BtnIleri";
            this.BtnIleri.Size = new System.Drawing.Size(87, 31);
            this.BtnIleri.TabIndex = 1;
            this.BtnIleri.Text = ">";
            this.BtnIleri.UseVisualStyleBackColor = false;
            this.BtnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGeri.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGeri.Location = new System.Drawing.Point(706, 198);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(87, 31);
            this.BtnGeri.TabIndex = 1;
            this.BtnGeri.Text = "<";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnSon
            // 
            this.BtnSon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSon.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSon.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSon.Location = new System.Drawing.Point(892, 198);
            this.BtnSon.Name = "BtnSon";
            this.BtnSon.Size = new System.Drawing.Size(87, 31);
            this.BtnSon.TabIndex = 1;
            this.BtnSon.Text = ">>>";
            this.BtnSon.UseVisualStyleBackColor = false;
            this.BtnSon.Click += new System.EventHandler(this.BtnSon_Click);
            // 
            // BtnIlk
            // 
            this.BtnIlk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnIlk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnIlk.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnIlk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIlk.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIlk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIlk.Location = new System.Drawing.Point(613, 198);
            this.BtnIlk.Name = "BtnIlk";
            this.BtnIlk.Size = new System.Drawing.Size(87, 31);
            this.BtnIlk.TabIndex = 1;
            this.BtnIlk.Text = "<<<";
            this.BtnIlk.UseVisualStyleBackColor = false;
            this.BtnIlk.Click += new System.EventHandler(this.BtnIlk_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(606, 436);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "İLK KAYIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "GERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(904, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "SON KAYIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(820, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "İLERİ";
            // 
            // FrmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1014, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnIlk);
            this.Controls.Add(this.BtnSon);
            this.Controls.Add(this.BtnIleri);
            this.Name = "FrmKategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.FrmKategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnIleri;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnSon;
        private System.Windows.Forms.Button BtnIlk;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}