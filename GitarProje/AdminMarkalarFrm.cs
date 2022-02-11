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
    public partial class AdminMarkalarFrm : Form
    {
        public AdminMarkalarFrm()
        {
            InitializeComponent();
        }
        void temizle()
        {
            TxtİD.Text = "";
            Txtadi.Text = "";
        }

        SqlBaglanti bgl = new SqlBaglanti();
        void listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
            ("select * from markalar", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        private void AdminMarkalarFrm_Load(object sender, EventArgs e)
        {
            listele();
            gridView1.Columns[0].Caption = "Marka No";
            gridView1.Columns[1].Caption = "Marka Adı";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into markalar (markaadi)" +
                "values(@p2)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p2", Txtadi.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from markalar where markaid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtİD.Text = dr["markaid"].ToString();
                Txtadi.Text = dr["markaadi"].ToString();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update markalar set markaadi=@p1 where markaid=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", Txtadi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
