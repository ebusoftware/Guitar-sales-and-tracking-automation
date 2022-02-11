using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GitarProje
{
    public partial class FrmGovdeler : Form
    {
        public FrmGovdeler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void GovdeListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from govdeler", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        private void FrmGovdeler_Load(object sender, EventArgs e)
        {
            GovdeListele();
        }

        private void BtnSon_Click(object sender, EventArgs e)
        {
            gridView1.MoveLast();
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            gridView1.FocusedRowHandle++;
        }

        private void BtnIlk_Click(object sender, EventArgs e)
        {
            gridView1.MoveFirst();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            gridView1.FocusedRowHandle--;
        }
    }
}
