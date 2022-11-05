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
    public partial class frm_yeniKullanici : Form
    {
        public frm_yeniKullanici()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        char? none = null;
        private void cbxGorunurluk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxGorunurluk.Checked)
            {
                txbSifre.PasswordChar = Convert.ToChar(none);
                txbSifreOnay.PasswordChar = Convert.ToChar(none);
            }
            else
            {
                txbSifre.PasswordChar = '*';
                txbSifreOnay.PasswordChar = '*';
            }
        }

        string yetkiSifresi = "iste";

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbYetki.Text == yetkiSifresi)
                if (txbKullaniciAdi.Text != "" && txbSifre.Text != "" && txbSifreOnay.Text != "")
                    if (cbxRobot.Checked)
                        if (txbSifre.Text == txbSifreOnay.Text)
                        {
                            sorgu = "select * from tbl_login where username = '" + txbKullaniciAdi.Text + "'";
                            if (!Veritabani.Karsilastir(sorgu))
                            {
                                SqlCommand cmd = new SqlCommand();
                                cmd.Parameters.AddWithValue("@kullaniciAdi", txbKullaniciAdi.Text);
                                cmd.Parameters.AddWithValue("@sifre", Veritabani.MD5Sifrele(txbSifre.Text));
                                Veritabani.islemYap(cmd, "insert into tbl_login values(@kullaniciAdi, @sifre)");

                                MessageBox.Show("Kullanıcı başarıyla oluşturuldu. Giriş formuna yönlendiriliyorsunuz...");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bu kullanıcı adı daha önce oluşturulmuş. Lütfen başka bir kullanıcı adı seçin.");
                                txbKullaniciAdi.Clear(); txbSifre.Clear(); txbSifreOnay.Clear(); txbKullaniciAdi.Focus();
                            }
                        }
                        else
                            MessageBox.Show("'Şifre' ile 'Şifre Onay' uyuşmuyor!");
                    else
                        MessageBox.Show("Lütfen robot olmadığınızı doğrulayın.");
                else
                    MessageBox.Show("Lütfen boş alanları doldurun.");
            else
                MessageBox.Show("'Yetki Şifresini' doğru girmelisiniz!");
        }

        string sorgu = "";
        private void button2_Click(object sender, EventArgs e)
        {
            if (txbYetki.Text == yetkiSifresi)
                if (txbKullaniciAdi.Text != "" && txbSifre.Text != "" && txbSifreOnay.Text != "")
                    if (cbxRobot.Checked)
                        if (txbSifre.Text == txbSifreOnay.Text)
                        {
                            sorgu = "select * from tbl_login where username = '" + txbKullaniciAdi.Text + "' and password = '" + Veritabani.MD5Sifrele(txbSifre.Text) + "'";
                            if (Veritabani.Karsilastir(sorgu))
                            {
                                SqlCommand cmd1 = new SqlCommand();
                                cmd1.Parameters.AddWithValue("@kullaniciAdi", txbKullaniciAdi.Text);
                                cmd1.Parameters.AddWithValue("@sifre", Veritabani.MD5Sifrele(txbSifre.Text));
                                Veritabani.islemYap(cmd1, "delete from tbl_login where username = @kullaniciAdi and password = @sifre");

                                MessageBox.Show("Kullanıcı başarıyla silindi...");
                                txbKullaniciAdi.Clear(); txbSifre.Clear(); txbSifreOnay.Clear(); txbYetki.Clear();
                                cbxRobot.Checked = false;
                                cbxGorunurluk.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("Böyle bir kullanıcı kayıtı bulunamadı.");
                                txbKullaniciAdi.Clear(); txbSifre.Clear(); txbSifreOnay.Clear(); txbKullaniciAdi.Focus();
                            }
                        }
                        else
                            MessageBox.Show("'Şifre' ile 'Şifre Onay' uyuşmuyor!");
                    else
                        MessageBox.Show("Lütfen robot olmadığınızı doğrulayın.");
                else
                    MessageBox.Show("Lütfen boş alanları doldurun.");
            else
                MessageBox.Show("'Yetki Şifresini' doğru girmelisiniz!");
        }
    }
}
