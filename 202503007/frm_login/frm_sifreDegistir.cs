using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_login
{
    public partial class frm_sifreDegistir : Form
    {
        public frm_sifreDegistir()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string sorgu = "";
        private void txbEskiSifre_TextChanged(object sender, EventArgs e)
        {
            sorgu = "select * from tbl_login where username = '" + frm_login.kullanicimSession + "' and password = '" + Veritabani.MD5Sifrele(txbEskiSifre.Text) + "'";
            if (Veritabani.Karsilastir(sorgu))
            {
                txbYeniSifre.Enabled = true; txbYeniSifreOnay.Enabled = true;
                txbYeniSifre.BackColor = Color.FromArgb(54, 56, 55);
                txbYeniSifreOnay.BackColor = Color.FromArgb(54, 56, 55);
            }
            else
            {
                txbYeniSifre.Enabled = false; txbYeniSifreOnay.Enabled = false;
                txbYeniSifre.BackColor = Color.LightGray;
                txbYeniSifreOnay.BackColor = Color.LightGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbEskiSifre.Text != "" && txbYeniSifre.Text != "" && txbYeniSifreOnay.Text != "")
            {
                if (txbYeniSifre.Text == txbYeniSifreOnay.Text)
                {
                    Veritabani.SifreGuncelle(txbEskiSifre.Text, txbYeniSifre.Text);
                    MessageBox.Show("Şifre başarılı bir şekilde güncellendi.");

                    txbEskiSifre.Clear(); txbYeniSifre.Clear(); txbYeniSifreOnay.Clear();
                    txbYeniSifre.Enabled = false; txbYeniSifreOnay.Enabled = false;
                    txbYeniSifre.BackColor = Color.LightGray;
                    txbYeniSifreOnay.BackColor = Color.LightGray;
                }
                else
                    MessageBox.Show("'Yeni şifre' ve 'Yeni Şifre Onay' uyuşmuyor!");
            }
            else
                MessageBox.Show("Lütfen boş alanları doldurun ve işleme öyle devam edin.");
        }
    }
}
