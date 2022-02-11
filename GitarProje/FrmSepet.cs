using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitarProje
{
    public partial class FrmSepet : Form
    {
        public FrmSepet()
        {
            InitializeComponent();
        }

        private void BtnOde_Click(object sender, EventArgs e)
        {
            if (RchAdet.Text != null && RchBirimFiyat.Text != null && RchUrunAdi.Text != null)
            {
                MessageBox.Show("Ödemeye Yönlendiriliyor...");
            }
            else
                MessageBox.Show("Lütfen Sepete Ürün ekleyiniz!");
        }
        public string Urunad,BirimAdet,fiyat;

        private void RchTutar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RchAdet.Text = null;
            RchBirimFiyat.Text = null;
            RchTutar.Text = null;
            RchUrunAdi.Text = null;
        }

        private void FrmSepet_Load(object sender, EventArgs e)
        {
            RchAdet.Text += BirimAdet;
            RchBirimFiyat.Text += fiyat;
            RchUrunAdi.Text += Urunad;
        }
    }
}
