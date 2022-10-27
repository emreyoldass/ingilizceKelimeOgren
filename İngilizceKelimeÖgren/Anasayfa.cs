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
using System.Drawing.Drawing2D;

namespace İngilizceKelimeÖgren
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();

        }
        private void btn_ekleKelime_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewKelimeEkle();
        }

        private void btn_updatekelime_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewKelimeGüncelleme();
        }


        private void btn_kelimebulmaeng_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewKelimeBulma();
        }

        private void btn_zamanaKarsiEng_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewZamanaKarsi();
        }

        private void btn_zamanaKarsiTürkce_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewKelimeZamanaKarsiTurkce();
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

        private void Anasayfa_Paint(object sender, PaintEventArgs e)
        {
            Graphics agraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(37, 51, 84));

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(25, 206, 235), Color.FromArgb(40, 172, 234), LinearGradientMode.Vertical);
            agraphics.FillRectangle(lgb, area);
            agraphics.DrawRectangle(pen, area);
        }

        private void btn_kelimebulmaturkce_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewKelimeBulmaTurkce();
        }

        private void btn_ögrendigimkelimeler_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewÖgrenciKelime();
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

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
