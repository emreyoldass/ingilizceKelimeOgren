using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace İngilizceKelimeÖgren
{
    public partial class KelimeEkleTurkce : Form
    {
        public KelimeEkleTurkce()
        {
            InitializeComponent();
           
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8RJDVGV;Initial Catalog=sozluk;Integrated Security=True");
        int sayi;

        
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_ingilizce.Text == string.Empty && txt_turkce.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Alanları Doldurun.");
            }
            else {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_sozluk(turkce,ingilizce) values(@p1,@p2)", baglanti);
                //OleDbCommand komut = new OleDbCommand("insert into sozluk(turkce,ingilizce) values(@p1,@p2)", baglanti);

                komut.Parameters.AddWithValue("@p1", txt_turkce.Text);
                komut.Parameters.AddWithValue("@p2", txt_ingilizce.Text);
                komut.ExecuteNonQuery();

                baglanti.Close();
                baglanti.Open();
                string sorgu = "Select COUNT('tbl_sozluk') From tbl_sozluk";
                SqlCommand komut2 = new SqlCommand(sorgu, baglanti);
                sayi = Convert.ToInt32(komut2.ExecuteScalar());
                lbl_sayi.Text = sayi.ToString();
                baglanti.Close();

                MessageBox.Show("Kelime  Eklendi");
                txt_turkce.Clear();
                txt_ingilizce.Clear();
            }
        }

        private void KelimeEkleTurkce_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select COUNT('tbl_sozluk') From tbl_sozluk";
            SqlCommand komut2 = new SqlCommand(sorgu, baglanti);
            sayi = Convert.ToInt32(komut2.ExecuteScalar());
            lbl_sayi.Text = sayi.ToString();
            baglanti.Close();
            
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewAnasayfa();
        }
        private void KelimeEkleTurkce_Paint(object sender, PaintEventArgs e)
        {
          
                Graphics agraphics = e.Graphics;
                Pen pen = new Pen(Color.FromArgb(37, 51, 84));

                Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(25, 206, 235), Color.FromArgb(40, 172, 234), LinearGradientMode.Vertical);
                agraphics.FillRectangle(lgb, area);
                agraphics.DrawRectangle(pen, area);
            
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

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_cikis_MouseEnter(object sender, EventArgs e)
        {
            Panel_Ayarlar.Cikis_MouseEnter(btn_cikis);
        }

        private void btn_cikis_MouseLeave(object sender, EventArgs e)
        {
            Panel_Ayarlar.Cikis_MouseLeave(btn_cikis);
        }
    }
}
