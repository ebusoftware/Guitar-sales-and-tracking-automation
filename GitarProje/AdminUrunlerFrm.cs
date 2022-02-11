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
    public partial class AdminUrunlerFrm : Form
    {
        public AdminUrunlerFrm()
        {
            InitializeComponent();
        }
        void temizle()
        {
            TxtİD.Text = "";
            TxtAciklama.Text = "";
            TxtAdi.Text = "";
            TxtBarkod.Text = "";
            TxtFiyat.Text = "";
            TxtGovde.Text = "";
            TxtKategori.Text = "";
            TxtMarka.Text = "";
            TxtStokadet.Text = "";
            TxtTelsayisi.Text = "";
            CmbRenk.Text = "";
            PctrBxUrunResm.ImageLocation = "";
        }


        SqlBaglanti bgl = new SqlBaglanti();
        void UrunListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
            ("select * from urunler", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        void sehirekle()
        {
            SqlCommand cmd = new SqlCommand("select * from renkler",bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbRenk.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        private void AdminUrunlerFrm_Load(object sender, EventArgs e)
        {
            UrunListele();
            sehirekle();
            gridView1.Columns[0].Caption = "Ürün No";
            gridView1.Columns[1].Caption = "Kategori";
            gridView1.Columns[2].Caption = "Marka";
            gridView1.Columns[3].Caption = "Gövde";
            gridView1.Columns[4].Caption = "Tel";
            gridView1.Columns[5].Caption = "Renk";
            gridView1.Columns[6].Caption = "Barkod";
            gridView1.Columns[7].Caption = "Ürün Adı";
            gridView1.Columns[8].Caption = "Fiyat";
            gridView1.Columns[9].Caption = "Stok Adeti";
            gridView1.Columns[10].Caption = "Açıklama";
            gridView1.Columns[11].Caption = "Resim yolu";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into urunler (kategoriid,markaid,govdeid,telid,renkid,barkodno,urunadi,fiyat,stokadeti,aciklama,resim)" +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,11)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtKategori.Text);
            cmd.Parameters.AddWithValue("@p2", TxtMarka.Text);
            cmd.Parameters.AddWithValue("@p3", TxtGovde.Text);
            cmd.Parameters.AddWithValue("@p4", TxtTelsayisi.Text);
            cmd.Parameters.AddWithValue("@p5", CmbRenk.Text);
            cmd.Parameters.AddWithValue("@p6", TxtBarkod.Text);
            cmd.Parameters.AddWithValue("@p7", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p8", TxtFiyat.Text);
            cmd.Parameters.AddWithValue("@p9", TxtStokadet.Text);
            cmd.Parameters.AddWithValue("@p10", TxtAciklama.Text);
            cmd.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            UrunListele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtİD.Text = dr["urunid"].ToString();
                TxtAciklama.Text = dr["aciklama"].ToString();
                TxtAdi.Text = dr["urunadi"].ToString();
                TxtBarkod.Text = dr["barkodno"].ToString();
                TxtFiyat.Text = dr["fiyat"].ToString();
                TxtGovde.Text = dr["govdeid"].ToString();
                TxtKategori.Text = dr["kategoriid"].ToString();
                TxtMarka.Text = dr["markaid"].ToString();
                TxtStokadet.Text = dr["stokadeti"].ToString();
                TxtTelsayisi.Text = dr["telid"].ToString();
                CmbRenk.Text = dr["renkid"].ToString();
                yeniyol = "C:\\Users\\pc\\OneDrive\\Masaüstü\\OkulProje\\Ebubekir_aydogmus_odevhafta4\\c#\\GitarProje" + "\\Resimler\\" + dr["resim"].ToString();
                PctrBxUrunResm.ImageLocation = yeniyol;


            }
        }
        public string yeniyol;
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*png;*nef |Tüm Dosyalar|*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\pc\\OneDrive\\Masaüstü\\OkulProje\\Ebubekir_aydogmus_odevhafta4\\c#\\GitarProje"+"\\Resimler\\"+ Guid.NewGuid().ToString()+".jpg";
            File.Copy(dosyayolu,yeniyol);
            PctrBxUrunResm.ImageLocation = yeniyol;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update urunler set kategoriid=@p1,markaid=@p2,govdeid=@p3,telid=@p4,renkid=@p5,barkodno=" +
                "@p6,urunadi=@p7,fiyat=@p8,stokadeti=@p9,aciklama=@p10,resim=@p11 where urunid=@p12",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtKategori.Text);
            cmd.Parameters.AddWithValue("@p2", TxtMarka.Text);
            cmd.Parameters.AddWithValue("@p3", TxtGovde.Text);
            cmd.Parameters.AddWithValue("@p4", TxtTelsayisi.Text);
            cmd.Parameters.AddWithValue("@p5", CmbRenk.Text);
            cmd.Parameters.AddWithValue("@p6", TxtBarkod.Text);
            cmd.Parameters.AddWithValue("@p7", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p8", TxtFiyat.Text);
            cmd.Parameters.AddWithValue("@p9", TxtStokadet.Text);
            cmd.Parameters.AddWithValue("@p10", TxtAciklama.Text);
            cmd.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            cmd.Parameters.AddWithValue("@p12", TxtİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from urunler where urunid=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtİD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            UrunListele();
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
