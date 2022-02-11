using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitarProje
{
    public partial class AnasayfaFrm : Form
    {
        public AnasayfaFrm()
        {
            InitializeComponent();
        }
        Ürünler frmUrunler;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunler == null || frmUrunler.IsDisposed)
            {
                frmUrunler = new Ürünler();
                frmUrunler.MdiParent = this;
                frmUrunler.Show();
            }
        }
        FrmKategoriler frmKategoriler;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             if (frmKategoriler == null || frmKategoriler.IsDisposed)
            {
                frmKategoriler = new FrmKategoriler();
                frmKategoriler.MdiParent = this;
                frmKategoriler.Show();
            }
        }
        FrmMarkalar frmMarkalar;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMarkalar == null || frmMarkalar.IsDisposed)
            {
                frmMarkalar = new FrmMarkalar();
                frmMarkalar.MdiParent = this;
                frmMarkalar.Show();
            }
        }
        FrmGovdeler frmGovdeler;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGovdeler == null || frmGovdeler.IsDisposed)
            {
                frmGovdeler = new FrmGovdeler();
                frmGovdeler.MdiParent = this;
                frmGovdeler.Show();
            }
        }
        FrmSepet frmSepet;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSepet == null || frmSepet.IsDisposed)
            {
                frmSepet = new FrmSepet();
                frmSepet.MdiParent = this;
                frmSepet.Show();
            }
        }
        FrmTeller frmTeller;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmTeller == null || frmTeller.IsDisposed)
            {
                frmTeller = new FrmTeller();
                frmTeller.MdiParent = this;
                frmTeller.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            AdminGirisPanelFrm adminGirisPanelFrm = new AdminGirisPanelFrm();
            adminGirisPanelFrm.Show();
            this.Hide();
        }

        private void AnasayfaFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
