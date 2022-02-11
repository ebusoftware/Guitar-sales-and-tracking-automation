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
    public partial class FrmYeniKullanici : Form
    {
        public FrmYeniKullanici()
        {
            InitializeComponent();
        }

        private void BtnAnasayfa_Click(object sender, EventArgs e)
        {
            AnasayfaFrm anasayfaFrm = new AnasayfaFrm();
            anasayfaFrm.Show();
            this.Hide();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnKullaniciEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into adminler (k_adi,sifre,admin_adsoyad)" +
                "values(@p1,@p2,@p3)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
            cmd.Parameters.AddWithValue("@p3", TxtAdiSoyadi.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Admin eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
