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
    public partial class ZamanaKarsiTürkce : Form
    {
        public ZamanaKarsiTürkce()
        {
            InitializeComponent();
        }

        private void ZamanaKarsiTürkce_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8RJDVGV;Initial Catalog=sozluk;Integrated Security=True");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;

        void getir()
        {
            int sayi = rast.Next(1, 2490);


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_türkce.Text = dr[2].ToString();
                lbl_cevap.Text = dr[1].ToString();
                lbl_cevap.Text = lbl_cevap.Text.ToLower();
            }
            baglanti.Close();

        }



        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewAnasayfa();
        }
        private void txt_ingilizce_TextChanged(object sender, EventArgs e)
        {
            if (txt_ingilizce.Text == lbl_cevap.Text)
            {

                ögrencidetay.ögrenilenKelime(txt_ingilizce.Text, txt_türkce.Text);
                kelime++;
                lbl_kelime.Text = kelime.ToString();
                getir();
                txt_ingilizce.Clear();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lbl_sure.Text = sure.ToString();
            if (sure == 0)
            {
                txt_türkce.Enabled = false;
                txt_ingilizce.Enabled = false;
                timer1.Stop();

            }
        }
        private void btn_ipucu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbl_cevap.Text, "İpucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ZamanaKarsiTürkce_Paint(object sender, PaintEventArgs e)
        {
            Graphics agraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(37, 51, 84));

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(25, 206, 235), Color.FromArgb(40, 172, 234), LinearGradientMode.Vertical);
            agraphics.FillRectangle(lgb, area);
            agraphics.DrawRectangle(pen, area);
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
