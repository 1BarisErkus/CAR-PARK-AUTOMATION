using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;
using CrystalDecisions.Windows.Forms;

namespace frm_login
{
    internal class Veritabani
    {
        static string connString = @"Data Source =localhost\SQLEXPRESS; Initial Catalog =202503007; Integrated Security =true;";
        static SqlConnection conn;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static SqlDataAdapter da;

        public static bool LoginKontrol(string kullaniciAdi, string sifre)
        {
            string sorgu = "select * from tbl_login where username = @kullaniciAdi and password = @sifre";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", Veritabani.MD5Sifrele(sifre));
            conn.Open();

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı. Ana Ekrana yönlendiriliyorsunuz...");
                conn.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı!");
                conn.Close();
                return false;
            }
        }

        public static string MD5Sifrele(string sifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
                sb.Append(item.ToString("x2").ToLower());
            return sb.ToString();
        }

        public static void islemYap(SqlCommand cmd, string sorgu)
        {
            conn = new SqlConnection(connString);
            cmd.CommandText = sorgu;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void AracEkle(string adSoyad, string plaka, DateTime girisZamani, string marka,
            string model, string renk, string yakitTuru, string saatorGun, int vale, int yikama, string acikorKapali)
        {
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@adsoyad", adSoyad);
            cmd.Parameters.AddWithValue("@plaka", plaka);
            cmd.Parameters.AddWithValue("@girisZamani", girisZamani);
            cmd.Parameters.AddWithValue("@marka", marka);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@renk", renk);
            cmd.Parameters.AddWithValue("@yakitTuru", yakitTuru);
            cmd.Parameters.AddWithValue("@saatorGun", saatorGun);
            cmd.Parameters.AddWithValue("@vale", vale);
            cmd.Parameters.AddWithValue("@yikama", yikama);
            cmd.Parameters.AddWithValue("@acikorKapali", acikorKapali);
            islemYap(cmd, "insert into tbl_cars values(@adsoyad, @plaka, @girisZamani, @marka, @model, @renk, @yakitTuru, @saatorGun, @vale, @yikama, @acikorKapali)");
        }

        public static void SifreGuncelle(string eskiSifre, string yeniSifre)
        {
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@eskiSifre", MD5Sifrele(eskiSifre));
            cmd.Parameters.AddWithValue("@yeniSifre", MD5Sifrele(yeniSifre));
            islemYap(cmd, "update tbl_login set password = @yeniSifre where password = @eskiSifre");
        }

        public static bool Karsilastir(string sorgu)
        {
            conn = new SqlConnection(connString);
            cmd = new SqlCommand(sorgu, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public static int AracSayisi()
        {
            conn = new SqlConnection(connString);
            cmd = new SqlCommand("select count(*) from tbl_cars", conn);
            conn.Open();
            int sayi = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return sayi;
        }

        public static DataGridView GridGuncelle(SqlCommand cmd, DataGridView dataGridView, string sorgu)
        {
            conn = new SqlConnection(connString);

            cmd.Connection = conn;
            cmd.CommandText = sorgu;

            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
            return dataGridView;
        }

        public static void Raporla(CrystalReportViewer crystalReportViewer, string tabloAdi)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                if (tabloAdi == "tbl_kasa")
                {
                    CrystalReport1 cr1 = new CrystalReport1();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter("select * from " + tabloAdi, conn);
                    da.Fill(ds, tabloAdi);
                    cr1.SetDataSource(ds);
                    crystalReportViewer.ReportSource = cr1;
                    conn.Close();
                }
                else if (tabloAdi == "tbl_cars")
                {
                    CrystalReport2 cr2 = new CrystalReport2();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter("select * from " + tabloAdi, conn);
                    da.Fill(ds, tabloAdi);
                    cr2.SetDataSource(ds);
                    crystalReportViewer.ReportSource = cr2;
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir şeyler ters gitti!!");
            }
        }
    }
}
