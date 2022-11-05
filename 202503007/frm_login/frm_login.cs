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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        bool move;
        int x, y;
        int deneme_hakki = 2;

        public static string kullanicimSession = "";

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            if (txb_captcha.Text == sonuc.ToString())
                if (Veritabani.LoginKontrol(txb_kullaniciAdi.Text, txb_sifre.Text))
                {
                    AnaForm anaForm = new AnaForm();
                    this.Hide();
                    kullanicimSession = txb_kullaniciAdi.Text;
                    anaForm.ShowDialog();
                }
                else
                {
                    if (deneme_hakki == 0)
                    {
                        MessageBox.Show("3 defa yanlış giriş yaptınız. Uygulama kapatılıyor...");
                        Application.Exit();
                    }
                    MessageBox.Show(deneme_hakki + " deneme hakkınız kaldı!");
                    deneme_hakki--;
                    txb_kullaniciAdi.Clear(); txb_sifre.Clear(); txb_kullaniciAdi.Focus(); txb_captcha.Clear();
                    CaptchaOlustur();
                }
            else
            {
                MessageBox.Show("Captcha hatalı!!");
                txb_captcha.Clear();
                txb_captcha.Focus();
                CaptchaOlustur();
            }
        }

        public void CaptchaOlustur()
        {
            Random random = new Random();
            sayi1 = random.Next(0, 50);
            sayi2 = random.Next(0, 50);
            sonuc = sayi1 + sayi2;
            label1.Text = sayi1.ToString() + " + " + sayi2.ToString();
        }

        private void frm_login_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void txb_sifre_Enter(object sender, EventArgs e)
        {
            if (txb_sifre.Text == "Şifre")
            {
                txb_sifre.Text = "";
                txb_sifre.PasswordChar = '*';
            }
        }

        private void txb_kullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (txb_kullaniciAdi.Text == "")
                txb_kullaniciAdi.Text = "Kullanıcı Adı";
        }

        private void txb_kullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txb_kullaniciAdi.Text == "Kullanıcı Adı")
                txb_kullaniciAdi.Text = "";
        }

        private void frm_login_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_yeniKullanici yeniKullanici = new frm_yeniKullanici();
            yeniKullanici.ShowDialog();
        }

        int sayi1, sayi2, sonuc;
        private void frm_login_Load(object sender, EventArgs e)
        {
            CaptchaOlustur();
        }

        char? none = null;
        private void txb_sifre_Leave(object sender, EventArgs e)
        {
            if (txb_sifre.Text == "")
            {
                txb_sifre.Text = "Şifre";
                txb_sifre.PasswordChar = Convert.ToChar(none);
            }
        }
    }
}
