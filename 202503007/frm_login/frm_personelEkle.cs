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
    public partial class frm_personelEkle : Form
    {
        public frm_personelEkle()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string sorgu = "";
        private void button1_Click(object sender, EventArgs e)
        {
            sorgu = "select * from tbl_Personel where PTC = '" + txbTC.Text + "'";
            if (!Veritabani.Karsilastir(sorgu))
                if (txbAdSoyad.Text != "" && txbUcret.Text != "" && txbTC.Text != "" && txbAlan.Text != "" &&
                    cbxCalismaSaati.Text != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@TC", txbTC.Text);
                    cmd.Parameters.AddWithValue("@adSoyad", txbAdSoyad.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@alan", txbAlan.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@calismaSaati", Convert.ToInt32(cbxCalismaSaati.Text));
                    cmd.Parameters.AddWithValue("@ucret", Convert.ToInt32(txbUcret.Text.ToUpper()));
                    Veritabani.islemYap(cmd, "insert into tbl_Personel values(@TC, @adSoyad, @alan, @calismaSaati, @ucret)");

                    MessageBox.Show("Personel eklendi.");

                    txbAdSoyad.Clear(); txbTC.Clear(); txbUcret.Clear(); txbAlan.Clear();
                    cbxCalismaSaati.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("Lütfen boş alanları doldurunuz.");
            else
            {
                MessageBox.Show("Bu Personel daha önce eklenmiş.");

                txbAdSoyad.Clear(); txbTC.Clear(); txbUcret.Clear(); txbAlan.Clear();
                cbxCalismaSaati.SelectedIndex = -1;
            }
        }
    }
}
