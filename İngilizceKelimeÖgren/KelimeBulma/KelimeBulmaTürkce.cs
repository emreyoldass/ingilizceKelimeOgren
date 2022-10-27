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
    public partial class KelimeBulmaTürkce : Form
    {
        public KelimeBulmaTürkce()
        {
            InitializeComponent();
        }

        private void KelimeBulmaTürkce_Load(object sender, EventArgs e)
        {

            getir();
            turkcekelime = lbl_turkce.Text;
            foreach (var item in turkcekelime.ToCharArray(0, turkcekelime.Length))
            {
                dizi.Add(item);
            }

        }
        List<char> dizi = new List<char>();
        List<string> txt = new List<string>();
        string kelimeolustu;
        int harfler;
        string turkcekelime;
        Random rast = new Random();
        int harfsayac = 0;
        Random rnd = new Random();
        int x = 176;
        int y = 56;
        int olusanbuton = 0;
        int kac = 0;
        Button buton2;
        void getir()
        {
            int sayi = rnd.Next(1, 2490);


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_turkce.Text = dr[2].ToString();
                lbl_cevap.Text = dr[1].ToString();
            }
            baglanti.Close();

        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8RJDVGV;Initial Catalog=sozluk;Integrated Security=True");

        
        private void Btn_harfgetir_Click(object sender, EventArgs e)
        {
            harfsayac++;
            string karakter1, karakter2, karakter3, karakter4, karakter5, karakter6, karakter7,
                karakter8, karakter9, karakter10, karakter11, karakter12, karakter13, karakter14, karakter15, karakter16, karakter17, karakter18, karakter19, karakter20;

            buton2 = new Button();
            buton2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            if (lbl_turkce.Text.Length != olusanbuton)
            {
                if (kac >= 6)
                {
                    x = 176;
                    y += 50;
                    kac = 0;
                }
                switch (harfsayac)
                {
                    case 1:

                        buton2.Location = new System.Drawing.Point(x, y);
                        //butona harf verme

                        x += 50;
                        harfler = rast.Next(0, dizi.Count);
                        karakter1 = dizi[harfler].ToString();

                        buton2.Text = karakter1;
                        txt.Add(karakter1);
                        //harfi atadıktan sonra diziden silme
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click;

                        groupBox1.Controls.Add(buton2);


                        olusanbuton++;
                        kac++;
                        break;

                    case 2:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;
                        harfler = rast.Next(0, dizi.Count);
                        karakter2 = dizi[harfler].ToString();

                        buton2.Text = karakter2;
                        txt.Add(karakter2);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);

                        buton2.Click += Buton2_Click1;
                        groupBox1.Controls.Add(buton2);


                        olusanbuton++;
                        kac++;

                        break;

                    case 3:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter3 = dizi[harfler].ToString();

                        buton2.Text = karakter3;
                        txt.Add(karakter3);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click2;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 4:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter4 = dizi[harfler].ToString();

                        buton2.Text = karakter4;
                        txt.Add(karakter4);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click3;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 5:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter5 = dizi[harfler].ToString();

                        buton2.Text = karakter5;
                        txt.Add(karakter5);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click4;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 6:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter6 = dizi[harfler].ToString();

                        buton2.Text = karakter6;
                        txt.Add(karakter6);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click5;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 7:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;
                        harfler = rast.Next(0, dizi.Count);
                        karakter7 = dizi[harfler].ToString();

                        buton2.Text = karakter7;
                        txt.Add(karakter7);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click6;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 8:
                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter8 = dizi[harfler].ToString();

                        buton2.Text = karakter8;
                        txt.Add(karakter8);
                        dizi.RemoveAt(harfler);


                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click7;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 9:
                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter9 = dizi[harfler].ToString();

                        buton2.Text = karakter9;
                        txt.Add(karakter9);
                        dizi.RemoveAt(harfler);


                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click8;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 10:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter10 = dizi[harfler].ToString();

                        buton2.Text = karakter10;
                        txt.Add(karakter10);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click9;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 11:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter11 = dizi[harfler].ToString();

                        buton2.Text = karakter11;
                        txt.Add(karakter11);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click10;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 12:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter12 = dizi[harfler].ToString();

                        buton2.Text = karakter12;
                        txt.Add(karakter12);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click11;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 13:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter13 = dizi[harfler].ToString();

                        buton2.Text = karakter13;
                        txt.Add(karakter13);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click12;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 14:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;

                        harfler = rast.Next(0, dizi.Count);
                        karakter14 = dizi[harfler].ToString();

                        buton2.Text = karakter14;
                        txt.Add(karakter14);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click13;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 15:


                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;
                        harfler = rast.Next(0, dizi.Count);
                        karakter15 = dizi[harfler].ToString();

                        buton2.Text = karakter15;
                        txt.Add(karakter15);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click14;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;

                        break;
                    case 16:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;
                        harfler = rast.Next(0, dizi.Count);
                        karakter16 = dizi[harfler].ToString();

                        buton2.Text = karakter16;
                        txt.Add(karakter16);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click15;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 17:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;
                        harfler = rast.Next(0, dizi.Count);
                        karakter17 = dizi[harfler].ToString();

                        buton2.Text = karakter17;
                        txt.Add(karakter17);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click16;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 18:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;
                        harfler = rast.Next(0, dizi.Count);
                        karakter18 = dizi[harfler].ToString();

                        buton2.Text = karakter18;
                        txt.Add(karakter18);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click17;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 19:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;
                        harfler = rast.Next(0, dizi.Count);
                        karakter19 = dizi[harfler].ToString();

                        buton2.Text = karakter19;
                        txt.Add(karakter19);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click18;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                    case 20:

                        buton2.Location = new System.Drawing.Point(x, y);
                        x += 50;
                        harfler = rast.Next(0, dizi.Count);
                        karakter20 = dizi[harfler].ToString();

                        buton2.Text = karakter20;
                        txt.Add(karakter20);
                        dizi.RemoveAt(harfler);

                        buton2.Name = "button" + x.ToString();
                        buton2.Size = new System.Drawing.Size(50, 50);
                        buton2.Click += Buton2_Click19;
                        groupBox1.Controls.Add(buton2);
                        olusanbuton++;
                        kac++;

                        break;
                }

            }
            else
            {
                MessageBox.Show("Maksimum harf sayısına ulaşıldı");
            }
        }


        private void Buton2_Click(object sender, EventArgs e)
        {
            kelimeolustu += txt[0];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click1(object sender, EventArgs e)
        {
            kelimeolustu += txt[1];
            txt_cevap.Text = kelimeolustu;
        }

        private void Buton2_Click2(object sender, EventArgs e)
        {
            kelimeolustu += txt[2];
            txt_cevap.Text = kelimeolustu;
        }

        private void Buton2_Click3(object sender, EventArgs e)
        {
            kelimeolustu += txt[3];
            txt_cevap.Text = kelimeolustu;
        }

        private void Buton2_Click4(object sender, EventArgs e)
        {
            kelimeolustu += txt[4];
            txt_cevap.Text = kelimeolustu;
        }

        private void Buton2_Click5(object sender, EventArgs e)
        {
            kelimeolustu += txt[5];
            txt_cevap.Text = kelimeolustu;

        }

        private void Buton2_Click6(object sender, EventArgs e)
        {
            kelimeolustu += txt[6];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click7(object sender, EventArgs e)
        {
            kelimeolustu += txt[7];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click8(object sender, EventArgs e)
        {
            kelimeolustu += txt[8];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click9(object sender, EventArgs e)
        {
            kelimeolustu += txt[9];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click10(object sender, EventArgs e)
        {
            kelimeolustu += txt[10];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click11(object sender, EventArgs e)
        {
            kelimeolustu += txt[11];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click12(object sender, EventArgs e)
        {
            kelimeolustu += txt[12];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click13(object sender, EventArgs e)
        {
            kelimeolustu += txt[13];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click14(object sender, EventArgs e)
        {
            kelimeolustu += txt[14];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click15(object sender, EventArgs e)
        {
            kelimeolustu += txt[15];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click16(object sender, EventArgs e)
        {
            kelimeolustu += txt[16];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click17(object sender, EventArgs e)
        {
            kelimeolustu += txt[17];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click18(object sender, EventArgs e)
        {
            kelimeolustu += txt[18];
            txt_cevap.Text = kelimeolustu;
        }
        private void Buton2_Click19(object sender, EventArgs e)
        {
            kelimeolustu += txt[19];
            txt_cevap.Text = kelimeolustu;
        }

        int dogrukelime = 0;
        private void txt_cevap_TextChanged(object sender, EventArgs e)
        {
            if (txt_cevap.Text == lbl_turkce.Text)
            {
                ögrencidetay.ögrenilenKelime(lbl_turkce.Text, lbl_cevap.Text);
                dogrukelime++;
                lbl_kelimesayisi.Text = "Kelime: " + dogrukelime.ToString();
                getir();
                harfsayac = 0;
                olusanbuton = 0;
                txt.Clear();
                kelimeolustu = string.Empty;
                txt_cevap.Text = string.Empty;
                kac = 0;
                x = 176;
                y = 50;

                txt_cevap.Clear();
                groupBox1.Controls.Clear();

                //groupBox1.Controls.RemoveByKey(item.ToString());
                turkcekelime = lbl_turkce.Text;
                foreach (var item in turkcekelime.ToCharArray(0, turkcekelime.Length))
                {
                    dizi.Add(item);
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager.OpenNewAnasayfa();
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            kelimeolustu = string.Empty;
            txt_cevap.Text = string.Empty;
        }
        private void btn_ipucu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbl_turkce.Text, "İpucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /********************************************************************************************/
        private void KelimeBulmaTürkce_Paint(object sender, PaintEventArgs e)
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


