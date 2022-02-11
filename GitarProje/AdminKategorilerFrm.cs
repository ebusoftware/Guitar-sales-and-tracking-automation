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
    public partial class AdminKategorilerFrm : Form
    {
        public AdminKategorilerFrm()
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
            ("select * from kategoriler", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        private void AdminKategorilerFrm_Load(object sender, EventArgs e)
        {
            listele();
            gridView1.Columns[0].Caption = "Kategori No";
            gridView1.Columns[1].Caption = "Kategori Adı";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into kategoriler (kategoriadi)" +
               "values(@p2", bgl.baglanti());


            cmd.Parameters.AddWithValue("@p2", Txtadi.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtİD.Text = dr["kategoriid"].ToString();
                Txtadi.Text = dr["kategoriadi"].ToString();
                


            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update kategoriler set kategoriadi=@p1 where kategoriid=@p2", bgl.baglanti());

            cmd.Parameters.AddWithValue("@p1", Txtadi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from kategoriler where kategoriid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kategori Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            gridView1.FocusedRowHandle++;
        }

        private void BtnSon_Click(object sender, EventArgs e)
        {
            gridView1.MoveLast();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            gridView1.FocusedRowHandle--;
        }

        private void BtnIlk_Click(object sender, EventArgs e)
        {
            gridView1.MoveFirst();
        }
    }
}
