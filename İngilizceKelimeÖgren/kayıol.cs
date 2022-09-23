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
using System.Threading;

namespace İngilizceKelimeÖgren
{
    public partial class kayıol : Form
    {
        public kayıol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8RJDVGV;Initial Catalog=sozluk;Integrated Security=True");

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            
            if (txt_ad.Text == string.Empty || txt_soyad.Text == string.Empty || txt_email.Text == string.Empty || txt_kullaniciad.Text == string.Empty || txt_sifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kullanicigiris (Ad,Soyad,Email,KullanıcıAdı,Şifre) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
                komut.Parameters.AddWithValue("@p3", txt_email.Text);
                komut.Parameters.AddWithValue("@p4", txt_kullaniciad.Text);
                komut.Parameters.AddWithValue("@p5", txt_sifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Thread.Sleep(1000);
                MessageBox.Show("Anasayfa dönüyorsunuz");
               
                
                //bu formu kapatacak
                this.Close();
                
               
                
               
                
            }
        }


        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }
        private void kayıol_Load(object sender, EventArgs e)
        {

        }
        private void btn_cikis_MouseEnter(object sender, EventArgs e)
        {
            Panel_Ayarlar.Cikis_MouseEnter(btn_cikis);
        }

        private void btn_cikis_MouseLeave(object sender, EventArgs e)
        {
            Panel_Ayarlar.Cikis_MouseLeave(btn_cikis);
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
