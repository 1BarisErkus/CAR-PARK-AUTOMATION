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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void formgetir(Form frm)
        {
            panel1.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }


        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbAracGiris_Click(object sender, EventArgs e)
        {
            frm_aracEkle aracEkle = new frm_aracEkle();
            panel1.Dock = DockStyle.Fill;
            formgetir(aracEkle);
        }

        private void tsbAracListele_Click(object sender, EventArgs e)
        {
            frm_aracListele aracListele = new frm_aracListele();
            panel1.Dock = DockStyle.Fill;
            formgetir(aracListele);
        }

        private void tsbAracCikis_Click(object sender, EventArgs e)
        {
            frm_aracListele aracListele = new frm_aracListele();
            panel1.Dock = DockStyle.Fill;
            formgetir(aracListele);
            aracListele.btnAracSil.Visible = true;
            aracListele.btn_filtrele.Visible = false;
            aracListele.btn_personelArac.Visible = false;
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_personelEkle personelEkle = new frm_personelEkle();
            panel1.Dock = DockStyle.Fill;
            formgetir(personelEkle);
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_personelListele personelListele = new frm_personelListele();
            panel1.Dock = DockStyle.Fill;
            formgetir(personelListele);
            personelListele.btnPersonelGuncelle.Visible = false;
            personelListele.btnPersonelSil.Visible = true;
            personelListele.textBox1.Visible = true;
            personelListele.textBox2.Visible = false;
        }

        private void tsbPersonelListele_Click(object sender, EventArgs e)
        {
            frm_personelListele personelListele = new frm_personelListele();
            panel1.Dock = DockStyle.Fill;
            formgetir(personelListele);
            personelListele.textBox1.Visible = true;
            personelListele.textBox2.Visible = false;
        }

        private void tsbGiriseDon_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            this.Close();
            login.Show();
        }

        private void tsbAracKayitSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Veritabani.islemYap(cmd, "delete from tbl_cars");
            MessageBox.Show("Araç listesi kalıcı olarak temizlendi.");
        }

        private void tsbPersonelKayitSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Veritabani.islemYap(cmd, "delete from tbl_Personel");
            MessageBox.Show("Personel listesi kalıcı olarak temizlendi.");
        }

        private void tsbSifreDegistir_Click(object sender, EventArgs e)
        {
            frm_sifreDegistir sifreDegistir = new frm_sifreDegistir();
            panel1.Dock = DockStyle.Fill;
            formgetir(sifreDegistir);
        }

        private void tsbKasayiBosalt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Veritabani.islemYap(cmd, "delete from tbl_kasa");
            MessageBox.Show("Kasa kalıcı olarak boşaltıldı.");
        }

        private void tsbKasa_Click(object sender, EventArgs e)
        {
            frm_kasa kasa = new frm_kasa();
            panel1.Dock = DockStyle.Fill;
            formgetir(kasa);
        }

        private void tsbPersonelGuncelle_Click(object sender, EventArgs e)
        {
            frm_personelListele personelListele = new frm_personelListele();
            panel1.Dock = DockStyle.Fill;
            formgetir(personelListele);
            personelListele.btnPersonelSil.Visible = false;
            personelListele.btnPersonelGuncelle.Visible = true;
            personelListele.textBox1.Visible = false;
            personelListele.textBox2.Visible = true;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void raporlamaSayfasınaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_raporlama raporlama = new frm_raporlama();
            raporlama.WindowState = FormWindowState.Maximized;
            raporlama.Show();
        }
    }
}
