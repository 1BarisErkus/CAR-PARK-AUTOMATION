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
    public partial class frm_personelListele : Form
    {
        public frm_personelListele()
        {
            InitializeComponent();
        }


        string sorgu = "";
        SqlCommand cmd = new SqlCommand();
        private void frm_personelListele_Load(object sender, EventArgs e)
        {
            sorgu = "select * from tbl_Personel";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                Veritabani.islemYap(cmd, "delete from tbl_Personel where PTC = @tc");

                sorgu = "select * from tbl_Personel";
                MessageBox.Show("Personel silindi.");
                Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
                TabloGorunum();
                KayitSayisi();
            }
            else
                MessageBox.Show("Herhangi bir Personel seçmediniz!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbTC.Checked)
                sorgu = "select * from tbl_Personel where PTC like '" + textBox1.Text + "%'";
            else if (rbAdSoyad.Checked)
                sorgu = "select * from tbl_Personel where PAdSoyad like '" + textBox1.Text.ToUpper() + "%'";
            else if (rbAlan.Checked)
                sorgu = "select * from tbl_Personel where PAlan like '" + textBox1.Text.ToUpper() + "%'";
            else if (rbCalismaSaati.Checked)
                sorgu = "select * from tbl_Personel where PCalismaSaati like '" + textBox1.Text.ToUpper() + "%'";
            else if (rbUcret.Checked)
                sorgu = "select * from tbl_Personel where PUcret like '" + textBox1.Text.ToUpper() + "%'";

            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();

        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (rbTC.Checked)
                sorgu = "update tbl_Personel set PTC = @tbx2 where PTC = @dgv1";
            else if (rbAdSoyad.Checked)
                sorgu = "update tbl_Personel set PAdSoyad = @tbx2 where PTC = @dgv1";
            else if (rbAlan.Checked)
                sorgu = "update tbl_Personel set PAlan = @tbx2 where PTC = @dgv1";
            else if (rbCalismaSaati.Checked)
                sorgu = "update tbl_Personel set PCalismaSaati = @tbx2 where PTC = @dgv1";
            else if (rbUcret.Checked)
                sorgu = "update tbl_Personel set PUcret = @tbx2 where PTC = @dgv1";

            if (rbTC.Checked && Veritabani.Karsilastir("select * from tbl_Personel where PTC = '" + textBox2.Text + "'"))
                MessageBox.Show("Bu TC No zaten sistemde kayıtlı!");
            else
            {
                cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@tbx2", textBox2.Text.ToUpper());
                cmd.Parameters.AddWithValue("@dgv1", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                Veritabani.islemYap(cmd, sorgu);
                MessageBox.Show("Personel Güncellendi");
                Veritabani.GridGuncelle(cmd, dataGridView1, "select * from tbl_Personel");
                TabloGorunum();
                KayitSayisi();
            }
            textBox2.Clear();
        }

        public void KayitSayisi()
        {
            lblCount.Text = $"Toplam Kayıt Sayısı = {dataGridView1.RowCount - 1}";
        }

        public void TabloGorunum()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "TC No";
            dataGridView1.Columns[2].HeaderText = "Ad - Soyad";
            dataGridView1.Columns[3].HeaderText = "Alan";
            dataGridView1.Columns[4].HeaderText = "Çalışma Saati";
            dataGridView1.Columns[5].HeaderText = "Ücret";
        }
    }
}
