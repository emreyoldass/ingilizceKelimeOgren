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
    public partial class ÖgrendigimKelimeler : Form
    {
        public ÖgrendigimKelimeler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8RJDVGV;Initial Catalog=sozluk;Integrated Security=True");
        
        private void ÖgrendigimKelimeler_Load(object sender, EventArgs e)
        {
            getir();
            gridayar();
        }
        void getir()
        {
            string sr = "tbl_ögrenci" + Login.ad;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from " + sr + "", baglanti);


            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            data.DataSource = ds.Tables[0];
            baglanti.Close();
            lbl_adSoyad.Text = "İsim: "+ Login.ad + " " + "\nSoyisim: " + Login.soyad;

        }
        void gridayar()
        {

            data.AllowUserToResizeRows = false;
            data.ReadOnly = true;
            data.Columns[0].Visible = false;
            data.RowHeadersVisible = false;
            data.BorderStyle = BorderStyle.None;
            data.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            data.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            data.DefaultCellStyle.SelectionBackColor = Color.FromArgb(91, 181, 252);
            data.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            data.BackgroundColor = Color.White;

            data.EnableHeadersVisualStyles = false;
            data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 192, 217);
            data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data.AllowUserToResizeColumns = false;
        }

        private void ÖgrendigimKelimeler_Paint(object sender, PaintEventArgs e)
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

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewAnasayfa();
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
