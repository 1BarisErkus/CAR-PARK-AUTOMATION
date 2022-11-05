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
    public partial class frm_aracListele : Form
    {
        public frm_aracListele()
        {
            InitializeComponent();
        }

        string sorgu = "";
        private void frm_aracListele_Load(object sender, EventArgs e)
        {
            sorgu = "select * from tbl_cars";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();

            btn_filtrele.Visible = true;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbPlaka_TextChanged(object sender, EventArgs e)
        {
            sorgu = "select * from tbl_cars where Plaka like '" + txbPlaka.Text.ToUpper() + "%' order by Plaka ASC";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();
        }

        private void txbIsim_TextChanged(object sender, EventArgs e)
        {
            sorgu = "select * from tbl_cars where AdSoyad like '" + txbIsim.Text.ToUpper() + "%' order by AdSoyad ASC";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();
        }

        private void txbMarka_TextChanged(object sender, EventArgs e)
        {
            sorgu = "select * from tbl_cars where Marka like '" + txbMarka.Text.ToUpper() + "%' order by Marka ASC";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();
        }

        private void cbxRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorgu = "select * from tbl_cars where Renk like '" + cbxRenk.Text.ToUpper() + "%' order by Renk ASC";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();
        }

        private void cbxYakitTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorgu = "select * from tbl_cars where YakitTuru like '" + cbxYakitTuru.Text.ToUpper() + "%' order by YakitTuru ASC";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();
        }

        SqlCommand cmd = new SqlCommand();
        private void btnAracSil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@plaka", dataGridView1.CurrentRow.Cells[2].Value.ToString());

            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Araç personel aracıysa ücret alma
                if (Veritabani.Karsilastir("select tbl_cars.AdSoyad, tbl_Personel.PAdSoyad from tbl_cars INNER JOIN tbl_Personel" +
                " on tbl_cars.AdSoyad = tbl_Personel.PAdSoyad where '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' = tbl_Personel.PAdSoyad"))
                {
                    Veritabani.islemYap(cmd, "delete from tbl_cars where Plaka = @plaka");
                }
                else
                {
                    DateTime girisZamani = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                    DateTime cikisZamani = DateTime.Now;
                    TimeSpan ts = cikisZamani - girisZamani;

                    int ucret = 0, toplam = 0;

                    if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == "1")
                        toplam += 5;
                    if (dataGridView1.CurrentRow.Cells[10].Value.ToString() == "1")
                        toplam += 5;
                    if (dataGridView1.CurrentRow.Cells[11].Value.ToString() == "KAPALI")
                        ucret += 10;


                    if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "GÜNLÜK")
                    {
                        ucret += 200;
                        cikisZamani = DateTime.Today.AddDays(1);
                        ts = cikisZamani - girisZamani;
                        int gunSayisi = Convert.ToInt32(ts.Days.ToString());
                        toplam += gunSayisi * ucret;

                        //Eğer araç fikrini değiştirip aynı gün içinde çıkış yaparsa 1 günlük ücret al.
                        if (gunSayisi == 0)
                            toplam += ucret;
                    }
                    else if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "SAATLİK")
                    {
                        ucret += 10;
                        int gunSayisi = Convert.ToInt32(ts.Days.ToString());
                        int saatSayisi = Convert.ToInt32(ts.Hours.ToString());
                        saatSayisi += gunSayisi * 24;
                        toplam += saatSayisi * ucret;

                        ////Eğer araç fikrini değiştirip aynı saat içinde çıkış yaparsa 1 saatlik ücret al.
                        if (saatSayisi == 0)
                            toplam += ucret;
                    }

                    Veritabani.islemYap(cmd, "delete from tbl_cars where Plaka = @plaka");

                    //Kasaya ücreti ekle
                    cmd.Parameters.AddWithValue("@ucret", toplam);
                    Veritabani.islemYap(cmd, "insert into tbl_kasa values(@plaka, @ucret)");
                }

                sorgu = "select * from tbl_cars";
                MessageBox.Show("Araç silindi.");
                Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
                TabloGorunum();
                KayitSayisi();

            }
            else
                MessageBox.Show("Herhangi bir araç seçmediniz!");
            txbIsim.Clear(); txbMarka.Clear(); txbPlaka.Clear(); cbxRenk.SelectedIndex = -1; cbxYakitTuru.SelectedIndex = -1;
        }

        private void btn_filtrele_Click(object sender, EventArgs e)
        {
            if (txbIsim.Text != "" && txbPlaka.Text != "" && txbMarka.Text != "" && cbxRenk.SelectedIndex != -1 && cbxYakitTuru.SelectedIndex != -1)
            {
                string sorgu = "select * from tbl_cars where Plaka like @plaka + '%' and AdSoyad like @adSoyad + '%' and" +
                " Marka like @marka + '%' and Renk like @renk + '%' and YakitTuru like @yakitTuru + '%'";

                cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@plaka", txbPlaka.Text.ToUpper());
                cmd.Parameters.AddWithValue("@adSoyad", txbIsim.Text.ToUpper());
                cmd.Parameters.AddWithValue("@marka", txbMarka.Text.ToUpper());
                cmd.Parameters.AddWithValue("@renk", cbxRenk.Text.ToUpper());
                cmd.Parameters.AddWithValue("@yakitTuru", cbxYakitTuru.Text.ToUpper());
                Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
                TabloGorunum();
                KayitSayisi();
            }
            else
                MessageBox.Show("Lütfen boş alanları doldurun.");
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            DateTime baslangicZamani = dtpBaslangic.Value; DateTime bitisZamani = dtpBitis.Value;

            sorgu = "select * from tbl_cars where GirisZamani between @baslangicZamani and @bitisZamani order by GirisZamani DESC";

            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@baslangicZamani", baslangicZamani);
            cmd.Parameters.AddWithValue("@bitisZamani", bitisZamani);

            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);
            TabloGorunum();
            KayitSayisi();
        }

        private void btn_personelArac_Click(object sender, EventArgs e)
        {
            txbIsim.Clear(); txbMarka.Clear(); txbPlaka.Clear(); cbxRenk.SelectedIndex = -1; cbxYakitTuru.SelectedIndex = -1;
            sorgu = "Execute PersonelCar";
            Veritabani.GridGuncelle(cmd, dataGridView1, sorgu);

            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[2].HeaderText = "Alan";

            KayitSayisi();
        }

        public void KayitSayisi()
        {
            lblCount.Text = $"Toplam Kayıt Sayısı = {dataGridView1.RowCount - 1}";
        }

        public void TabloGorunum()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Plaka";
            dataGridView1.Columns[3].HeaderText = "Giriş Zamanı";
            dataGridView1.Columns[4].HeaderText = "Marka";
            dataGridView1.Columns[5].HeaderText = "Model";
            dataGridView1.Columns[6].HeaderText = "Renk";
            dataGridView1.Columns[7].HeaderText = "Yakıt Türü";
            dataGridView1.Columns[8].HeaderText = "Saat Gün";
            dataGridView1.Columns[9].HeaderText = "Vale";
            dataGridView1.Columns[10].HeaderText = "Yıkama";
            dataGridView1.Columns[11].HeaderText = "Açık Kapalı";
        }
    }
}
