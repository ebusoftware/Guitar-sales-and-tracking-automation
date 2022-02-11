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
    public partial class AdminSatıslarFrm : Form
    {
        public AdminSatıslarFrm()
        {
            InitializeComponent();
        }
        void temizle()
        {
            TxtAdet.Text = "";
            TxtBrFiyat.Text = "";
            TxtMusteriİD.Text = "";
            TxtSatisİD.Text = "";
            TxtTarih.Text = "";
            TxtUrunİD.Text = "";
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
            ("select * from satislar", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        private void AdminSatıslarFrm_Load(object sender, EventArgs e)
        {
            listele();
            gridView1.Columns[0].Caption = "Satış No";
            gridView1.Columns[1].Caption = "Ürün No";
            gridView1.Columns[2].Caption = "Müşteri No";
            gridView1.Columns[3].Caption = "Birim fiyat";
            gridView1.Columns[4].Caption = "Adet";
            gridView1.Columns[5].Caption = "Satış Tarihi";
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtMusteriİD.Text = dr["musteriid"].ToString();
                TxtSatisİD.Text = dr["satisid"].ToString();
                TxtUrunİD.Text = dr["urunid"].ToString();
                TxtBrFiyat.Text = dr["bfiyat"].ToString();
                TxtAdet.Text = dr["adet"].ToString();
                TxtTarih.Text = dr["tarih"].ToString();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into satislar (urunid,musteriid,bfiyat,adet,tarih)" +
                "values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtUrunİD.Text);
            cmd.Parameters.AddWithValue("@p2", TxtMusteriİD.Text);
            cmd.Parameters.AddWithValue("@p3", TxtBrFiyat.Text);
            cmd.Parameters.AddWithValue("@p4", TxtAdet.Text);
            cmd.Parameters.AddWithValue("@p5", TxtTarih.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Satış Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from satislar where satisid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtSatisİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Satış Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update urunler set urunid=@p1,musteriid=@p2,bfiyat=@p3,adet=@p4,tarih=@p5 where satisid=@6", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtUrunİD.Text);
            cmd.Parameters.AddWithValue("@p2", TxtMusteriİD.Text);
            cmd.Parameters.AddWithValue("@p3", TxtBrFiyat.Text);
            cmd.Parameters.AddWithValue("@p4", TxtAdet.Text);
            cmd.Parameters.AddWithValue("@p5", TxtTarih.Text);
            cmd.Parameters.AddWithValue("@p6", TxtSatisİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Satış Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
