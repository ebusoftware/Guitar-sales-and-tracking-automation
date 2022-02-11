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
    public partial class AdminKontrolFrm : Form
    {
        public AdminKontrolFrm()
        {
            InitializeComponent();
        }
        AdminUrunlerFrm adminUrunlerFrm;
        private void AdmnUrunBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminUrunlerFrm = new AdminUrunlerFrm();
            adminUrunlerFrm.MdiParent = this;
            adminUrunlerFrm.Show();
        }
        AdminMusterilerFrm AdminMusterilerFrm;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AdminMusterilerFrm = new AdminMusterilerFrm();
            AdminMusterilerFrm.MdiParent = this;
            AdminMusterilerFrm.Show();
        }
        AdminKategorilerFrm adminKategorilerFrm;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminKategorilerFrm = new AdminKategorilerFrm();
            adminKategorilerFrm.MdiParent = this;
            adminKategorilerFrm.Show();
        }
        AdminMarkalarFrm adminMarkalarFrm;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminMarkalarFrm = new AdminMarkalarFrm();
            adminMarkalarFrm.MdiParent = this;
            adminMarkalarFrm.Show();
        }
        AdminSatıslarFrm adminSatıslarFrm;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adminSatıslarFrm = new AdminSatıslarFrm();
            adminSatıslarFrm.MdiParent = this;
            adminSatıslarFrm.Show();

        }

        private void AdminKontrolFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
