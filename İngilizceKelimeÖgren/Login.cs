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
using System.Drawing.Drawing2D;

namespace İngilizceKelimeÖgren
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8RJDVGV;Initial Catalog=sozluk;Integrated Security=True");
     
        public static string idnumarası;
        public static string ad;
        public static string soyad;
        

        public void btn_giris_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanicigiris where KullanıcıAdı=@p1 and Şifre=@p2 ",baglanti);
            komut.Parameters.AddWithValue("@p1", txt_kullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
               idnumarası = dr[0].ToString();

                this.Hide();
                
                FormManager.OpenNewAnasayfa();
               
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreyi kontrol ediniz. ");
            }
            baglanti.Close();

          

            baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from kullanicigiris where id='" + idnumarası + "'", baglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();

                while (dr2.Read())
                {
                    ad = dr2[2].ToString();
                    soyad = dr2[3].ToString();
                }
                baglanti.Close();

            
          
            //calışıyor fakat sadece login sayafasında çalışıyor
            //baglanti.Open();
            //SqlCommand komut2 = new SqlCommand("select * from kullanicigiris where id='" + idnumarası + "'", baglanti);

            //SqlDataReader dr2 = komut2.ExecuteReader();

            //while (dr2.Read())
            //{
            //    ad = dr2[1].ToString();
            //    soyad = dr2[2].ToString();
            //}
            //baglanti.Close();
            //baglanti.Open();
            //SqlCommand komut3 = new SqlCommand("insert into tbl_kullanicidegerler(Ad,Soyad) values (@p1,@p2)", baglanti);
            //komut3.Parameters.AddWithValue("@p1", ad);
            //komut3.Parameters.AddWithValue("@p2", soyad);
            //komut3.ExecuteNonQuery();
            //baglanti.Close();

        }

        private void btn_kayıtol_Click(object sender, EventArgs e)
        {
            FormManager.OpenNewkayıtol();
            
            
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

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            FormManager.formoval(Login.ActiveForm);

            Graphics agraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(37, 51, 84));

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(25, 206, 235), Color.FromArgb(40, 172, 234), LinearGradientMode.Vertical);
            agraphics.FillRectangle(lgb, area);
            agraphics.DrawRectangle(pen, area);
        }

        private void Login_Load(object sender, EventArgs e)
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
/*
 * Select * from kullanicigiris where like'"+txt_kullaniciad.Text + "' and like '%"+txt_sifre+"%'"
 * */
