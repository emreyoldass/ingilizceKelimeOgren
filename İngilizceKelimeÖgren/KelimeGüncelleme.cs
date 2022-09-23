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
    public partial class KelimeGüncelleme : Form
    {
        public KelimeGüncelleme()
        {
            InitializeComponent();
        }


        private void KelimeGüncelleme_Load(object sender, EventArgs e)
        {
            getir();
            gridayar();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8RJDVGV;Initial Catalog=sozluk;Integrated Security=True");
        int sayim;
        void getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_sozluk  ", baglanti);
           
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            data.DataSource = ds.Tables[0];
            baglanti.Close();
            baglanti.Open();
            //string sorgu = "SELECT IDENT_CURRENT('sozluk')";
            string sorgu = "Select COUNT('tbl_sozluk') From tbl_sozluk";
            SqlCommand komut2 = new SqlCommand(sorgu, baglanti);
            sayim = Convert.ToInt32(komut2.ExecuteScalar());
            label5.Text = sayim.ToString();
            baglanti.Close();
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
            //data.AutoResizeColumnsDataGridViewAutoSizeColumnMode.Fill;
            //resimli ek kolon
            //DataGridViewImageColumn btnIptal = new DataGridViewImageColumn();
            //btnIptal.Image = Image.FromFile(@"C:\Users\Hermes\Downloads\delete2.png");
            //btnIptal.HeaderText = "Sil";
            //data.Columns.Add(btnIptal);




        }
        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan=data.SelectedCells[0].RowIndex;

            string ingilizce = data.Rows[secilialan].Cells[1].Value.ToString();
            string turkce = data.Rows[secilialan].Cells[2].Value.ToString();
            txt_ingilizce.Text = ingilizce;
            txt_turkce.Text = turkce;
  
            // txt_ingilizce.Text= data.CurrentRow.Cells[1].Value.ToString();
           // txt_turkce.Text = data.CurrentRow.Cells[2].Value.ToString();
        }
        void yenile(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet st = new DataSet();
            da.Fill(st);
            data.DataSource = st.Tables[0];
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_sozluk set ingilizce='" + txt_ingilizce.Text + "', turkce='" + txt_turkce.Text + "' where id='" + data.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            yenile("select*from tbl_sozluk");
            baglanti.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("select * from tbl_sozluk where ingilizce  like '%" + txt_ara.Text + "%' or turkce like '%" + txt_ara.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            data.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete  from tbl_sozluk where ingilizce=@p1", baglanti);
            SqlCommand komut2 = new SqlCommand("delete  from tbl_sozluk where turkce=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_ara.Text);
            komut2.Parameters.AddWithValue("@p1", txt_ara.Text);
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            yenile("Select * from tbl_sozluk"); 
            baglanti.Close();
            baglanti.Open();
            string sorgu = "Select COUNT('tbl_sozluk') From tbl_sozluk";
            SqlCommand komutsayi = new SqlCommand(sorgu, baglanti);
            sayim = Convert.ToInt32(komutsayi.ExecuteScalar());
            label5.Text = sayim.ToString();
            baglanti.Close();

        }

        /****************************************************************************************************/
        private void KelimeGüncelleme_Paint(object sender, PaintEventArgs e)
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



