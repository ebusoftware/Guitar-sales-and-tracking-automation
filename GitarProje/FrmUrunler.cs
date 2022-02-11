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
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();


        void UrunListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
            ("select urunid,resim,urunadi,fiyat,markaadi,kategoriadi,govdetürü,telsayisi,renkadi,aciklama from " +
            "urunler,markalar,kategoriler,govdeler,teller,renkler where urunler.govdeid=govdeler.govdeid and " +
            "urunler.kategoriid=kategoriler.kategoriid and urunler.telid=teller.telid and urunler.markaid=markalar.markaid and " +
            "urunler.renkid=renkler.renkid", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunListele();
                  //Ürün alanı gizleme
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false; 
            gridView1.Columns[8].Visible = false;
            //grid alanı isim değiştirme
            gridView1.Columns[2].Caption = "Ürün Adı";
            gridView1.Columns[3].Caption = "Marka Adı";
            gridView1.Columns[4].Caption = "Fiyat";
            gridView1.Columns[5].Caption = "Kategori Adı";
            gridView1.Columns[6].Caption = "Gövde Türü";
            gridView1.Columns[7].Caption = "Tel Sayısı";

        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                TxtUno1.Text = dataRow["urunid"].ToString();
                TxtUno.Text = dataRow["urunid"].ToString();
                TxtAdi1.Text = dataRow["urunadi"].ToString();
                TxtAdi2.Text = dataRow["urunadi"].ToString();
                TxtFiyat1.Text = dataRow["fiyat"].ToString();
                TxtFiyat2.Text = dataRow["fiyat"].ToString();
                TxtAciklama.Text = dataRow["aciklama"].ToString();
                TxtMarka.Text = dataRow["markaadi"].ToString();
                TxtKategori.Text = dataRow["kategoriadi"].ToString();
                TxtGovde.Text = dataRow["govdetürü"].ToString();
                TxtTelsayi.Text = dataRow["telsayisi"].ToString();
                TxtRenk.Text = dataRow["renkadi"].ToString();
                PctrBxUrunResm.ImageLocation= dataRow["resim"].ToString();

            }
        }
        public string text;
        private void BtnSptEkle_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            FrmSepet sepet = new FrmSepet();
            
            if (dr!=null)
            {
                sepet.Urunad = dr["urunadi"].ToString();
                sepet.BirimAdet = TxtAdet2.Text;
                sepet.fiyat = dr["fiyat"].ToString();
                sepet.Show();

            }


        }

        private void BtnIlk_Click(object sender, EventArgs e)
        {
            gridView1.MoveFirst();
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            gridView1.FocusedRowHandle++;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            gridView1.FocusedRowHandle--;
        }

        private void BtnSon_Click(object sender, EventArgs e)
        {
            gridView1.MoveLast();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
