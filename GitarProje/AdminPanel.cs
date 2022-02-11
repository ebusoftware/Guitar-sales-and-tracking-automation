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
    public partial class AdminGirisPanelFrm : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public AdminGirisPanelFrm()
        {
            InitializeComponent();
        }

        private void AdminGirisPanelFrm_Load(object sender, EventArgs e)
        {
            AcceptButton = BtnLogin;
            CancelButton = BtnCikis;
        }
        
        private void AdmnPnlLogin_Click(object sender, EventArgs e)
        {
            AdminKontrolFrm adminKontrolFrm = new AdminKontrolFrm();
            this.Hide();
            adminKontrolFrm.Show();
            
        }
                      
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string k_adi, sifre;
            k_adi = TxtKadi.Text;
            sifre = TxtSifre.Text;
            string sql = "select * from adminler where k_adi='" + TxtKadi.Text + "' AND sifre='" + TxtSifre.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {


                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı");
                    AdminKontrolFrm adminKontrolFrm = new AdminKontrolFrm();
                    adminKontrolFrm.Show();
                    
                }

            }
            catch (Exception)
            {

                MessageBox.Show("hatalı giriş");
            }

        }

        private void BtnAnasayfa_Click(object sender, EventArgs e)
        {
            AnasayfaFrm anasayfaFrm = new AnasayfaFrm();
            this.Hide();
            anasayfaFrm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BtnKullaniciEkle_Click(object sender, EventArgs e)
        {
            FrmYeniKullanici frmYeniKullanici = new FrmYeniKullanici();
            frmYeniKullanici.Show();
        }
    }
}
