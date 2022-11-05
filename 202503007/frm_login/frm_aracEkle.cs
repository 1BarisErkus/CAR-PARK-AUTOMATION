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

namespace frm_login
{
    public partial class frm_aracEkle : Form
    {
        public frm_aracEkle()
        {
            InitializeComponent();
        }
        private void btn_cikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string sorgu = "";
        private void button1_Click(object sender, EventArgs e)
        {
            //Otopark en fazla 50 araç kapasitesine sahiptir.
            if (Veritabani.AracSayisi() <= 50)
            {
                sorgu = "select * from tbl_cars where Plaka = '" + txbPlaka.Text + "'";
                if (!Veritabani.Karsilastir(sorgu))
                {
                    if (txbAdSoyad.Text != "" && txbPlaka.Text != "" && txbMarka.Text != "" && txbModel.Text != "" &&
                    cbxRenk.Text != "" && cbxYakitTuru.Text != "" && (rbAcik.Checked || rbKapali.Checked) &&
                    (rbGunluk.Checked || rbSaatlik.Checked))
                    {
                        if (cbxYakitTuru.SelectedIndex == 2 && rbKapali.Checked)
                            MessageBox.Show("LPG'li araçlar kapalı otoparka giremez!");
                        else
                        {
                            string saatorGun = ""; string acikorKapali = ""; int yikama = 0; int vale = 0;

                            if (rbSaatlik.Checked) saatorGun = "Saatlik";
                            else if (rbGunluk.Checked) saatorGun = "Günlük";

                            if (rbAcik.Checked) acikorKapali = "Açık";
                            else if (rbKapali.Checked) acikorKapali = "Kapalı";

                            if (checkBox1.Checked) yikama = 1;
                            else yikama = 0;

                            if (checkBox2.Checked) vale = 1;
                            else vale = 0;

                            Veritabani.AracEkle(txbAdSoyad.Text.ToUpper(), txbPlaka.Text.ToUpper(), DateTime.Now,
                                txbMarka.Text.ToUpper(), txbModel.Text.ToUpper(), cbxRenk.Text.ToUpper(), cbxYakitTuru.Text.ToUpper(),
                                saatorGun.ToUpper(), vale, yikama, acikorKapali.ToUpper());

                            MessageBox.Show("Araç eklendi.");

                            txbAdSoyad.Clear(); txbPlaka.Clear(); txbMarka.Clear(); txbModel.Clear();
                            cbxRenk.SelectedIndex = -1; cbxYakitTuru.SelectedIndex = -1; rbAcik.Checked = false;
                            rbGunluk.Checked = false; rbKapali.Checked = false; rbSaatlik.Checked = false;
                            checkBox1.Checked = false; checkBox2.Checked = false;
                        }
                    }
                    else
                        MessageBox.Show("Lütfen boş alanları doldurunuz.");
                }
                else
                {
                    MessageBox.Show("Bu araç daha önce eklenmiş ve henüz çıkış yapmamış.");

                    txbAdSoyad.Clear(); txbPlaka.Clear(); txbMarka.Clear(); txbModel.Clear();
                    cbxRenk.SelectedIndex = -1; cbxYakitTuru.SelectedIndex = -1; rbAcik.Checked = false;
                    rbGunluk.Checked = false; rbKapali.Checked = false; rbSaatlik.Checked = false;
                    checkBox1.Checked = false; checkBox2.Checked = false;
                }
            }
            else
                MessageBox.Show("Otoparkımızın tamamen dolu. Lütfen daha sonra tekrar geliniz.");
        }
    }
}

