using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İngilizceKelimeÖgren
{
    public class ögrencidetay
    {
        /* düzeltme yapılacak ilerde kelime eklenirken aynı datadan birden fazla bulunan kelime engellemek için
        public static void kontrol(string txt_ing, string txt_tr)
        {
            bool durum;
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8RJDVGV;Initial Catalog=sozluk;Integrated Security=True");
            baglanti.Open();
            string sr = "tbl_ögrenci" + Login.ad;
            string sorgu = "select * from '"+sr+"' where ingilizce like '%@p1%' or turkce like '%@p2%'";
            //string sorgu = "select * from '"+sr+"' where ingilizce like '%"txt.tr"%' or turkce like '%"txt.ing"%'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", txt_ing);
            komut.Parameters.AddWithValue("@p2", txt_tr);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
            
        }*/

        public static void ögrenilenKelime(string txt_ing, string txt_tr)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8RJDVGV;Initial Catalog=sozluk;Integrated Security=True");
            baglanti.Open();
            string sr = "tbl_ögrenci" + Login.ad;

            SqlCommand komut5 = new SqlCommand("SELECT Count(name) FROM sozluk.sys.sysobjects WHERE name= N'" + sr + "'", baglanti);
            int sonuc = (int)komut5.ExecuteScalar();

            if (sonuc != 0)
            {
                // MessageBox.Show("Bu isimde bir veritabanı var.");
                SqlCommand komut3 = new SqlCommand("insert into tbl_ögrenci" + Login.ad + "(ingilizce,turkce) values(@p1,@p2)", baglanti);
                komut3.Parameters.AddWithValue("@p1", txt_ing);
                komut3.Parameters.AddWithValue("@p2", txt_tr);
                komut3.ExecuteNonQuery();

            }
            else
            {
                string sorgu = "Create Table tbl_ögrenci" + Login.ad + "( id INT IDENTITY(1, 1), ingilizce NVARCHAR(50) NOT NULL,  turkce NVARCHAR(50) NOT NULL);";
                SqlCommand komut4 = new SqlCommand(sorgu, baglanti);
                komut4.ExecuteNonQuery();
                // ilk kayıdı dataya eklemek için gerekli
                SqlCommand komut3 = new SqlCommand("insert into tbl_ögrenci" + Login.ad + "(ingilizce,turkce) values(@p1,@p2)", baglanti);
                komut3.Parameters.AddWithValue("@p1", txt_ing);
                komut3.Parameters.AddWithValue("@p2", txt_tr);
                komut3.ExecuteNonQuery();

            }
            baglanti.Close();
        }
    }
}
            



