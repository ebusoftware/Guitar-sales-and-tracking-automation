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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl=new SqlBaglanti();
        void MarkaListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from markalar", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            gridView1.FocusedRowHandle--;
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
    }
}
