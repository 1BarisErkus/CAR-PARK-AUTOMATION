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
    public partial class frm_kasa : Form
    {
        public frm_kasa()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string sorgu = "";
        SqlCommand cmd = new SqlCommand();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sorgu = "select CarPlaka, Ucret from tbl_kasa where CarPlaka like '" + textBox1.Text.ToUpper() + "%' order by CarPlaka ASC";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();
            ToplamUcret();
        }

        private void frm_kasa_Load(object sender, EventArgs e)
        {
            sorgu = "select CarPlaka, Ucret from tbl_kasa";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();
            ToplamUcret();
        }

        public void KayitSayisi()
        {
            lblCount.Text = $"Toplam Kayıt Sayısı = {dataGridView1.RowCount - 1}";
        }

        public void TabloGorunum()
        {
            dataGridView1.Columns[0].HeaderText = "Plaka";
            dataGridView1.Columns[1].HeaderText = "Ücret";
        }

        public void ToplamUcret()
        {
            int top = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                top += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            lblToplamUcret.Text = $"Toplam Ücret = {top}";
        }
    }
}
