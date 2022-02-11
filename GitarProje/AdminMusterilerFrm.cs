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
using System.IO;
namespace GitarProje

{
    public partial class AdminMusterilerFrm : Form
    {
        public AdminMusterilerFrm()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void musteriListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
            ("select * from musteriler", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        void temizle()
        {
            TxtİD.Text = "";
            RchAdres.Text = "";
            TxtAdi.Text = "";
            TxtEposta.Text = "";
            TxtGsmNo.Text = "";
            TxtSehirİD.Text = "";
            TxtSoyadi.Text = "";
            TxtVergiNo.Text = "";
        }

        private void AdminMusterilerFrm_Load(object sender, EventArgs e)
        {
            musteriListele();
            gridView1.Columns[0].Caption = "Müşteri No";
            gridView1.Columns[1].Caption = "Şehir No";
            gridView1.Columns[2].Caption = "Adı";
            gridView1.Columns[3].Caption = "Soyadı";
            gridView1.Columns[4].Caption = "Telefon Numarası";
            gridView1.Columns[5].Caption = "Vergi Numarası";
            gridView1.Columns[6].Caption = "E-Posta";
            gridView1.Columns[7].Caption = "Adres";
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into musteriler (sehirid,adi,soyadi,gsmno,vergino,eposta,adres)" +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7", bgl.baglanti());

            cmd.Parameters.AddWithValue("@p1", TxtSehirİD.Text);
            cmd.Parameters.AddWithValue("@p2", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSoyadi.Text);
            cmd.Parameters.AddWithValue("@p4", TxtGsmNo.Text);
            cmd.Parameters.AddWithValue("@p5", TxtVergiNo.Text);
            cmd.Parameters.AddWithValue("@p6", TxtEposta.Text);
            cmd.Parameters.AddWithValue("@p7", RchAdres.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            musteriListele();
        }

        private void gridView1_FocusedRowObjectChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtİD.Text = dr["musteriid"].ToString();
                TxtSehirİD.Text = dr["sehirid"].ToString();
                TxtAdi.Text = dr["adi"].ToString();
                TxtSoyadi.Text = dr["soyadi"].ToString();
                TxtGsmNo.Text = dr["gsmno"].ToString();
                TxtVergiNo.Text = dr["vergino"].ToString();
                TxtEposta.Text = dr["eposta"].ToString();
                RchAdres.Text = dr["adres"].ToString();


            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Update musteriler set sehirid=@p1,adi=@p2,soyadi=@p3,gsmno=@p4,vergino=@p5,eposta=@p6,adres=@p7 where musteriid=@p8", bgl.baglanti());

            cmd.Parameters.AddWithValue("@p1", TxtSehirİD.Text);
            cmd.Parameters.AddWithValue("@p2", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSoyadi.Text);
            cmd.Parameters.AddWithValue("@p4", TxtGsmNo.Text);
            cmd.Parameters.AddWithValue("@p5", TxtVergiNo.Text);
            cmd.Parameters.AddWithValue("@p6", TxtEposta.Text);
            cmd.Parameters.AddWithValue("@p7", RchAdres.Text);
            cmd.Parameters.AddWithValue("@p8", TxtİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            musteriListele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from musteriler where musteriid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            musteriListele();
        }
    }
}
