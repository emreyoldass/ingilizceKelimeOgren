using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İngilizceKelimeÖgren
{
   
    public static class FormManager
    {
       
        public static void OpenNewkayıtol()
        {
            kayıol frm = new kayıol();
            Rectangle Bounds = new Rectangle(0, 0, frm.Width, frm.Height);
            int CornerRadius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            frm.Region = new Region(path);
            frm.Show();
        }
        public static void OpenNewLogin()
        {
            Login frm = new Login();
            frm.Show();
        }
        public static void OpenNewAnasayfa()
        {
            Anasayfa frm = new Anasayfa();
            formoval(frm);
            frm.Show();
        }
        public static void OpenNewKelimeEkle()
        {
            KelimeEkleTurkce frm = new KelimeEkleTurkce();
            formoval(frm);
            frm.Show();
        }
        public static void OpenNewKelimeGüncelleme()
        {
            KelimeGüncelleme frm = new KelimeGüncelleme();
            formoval(frm);
            frm.Show();
        }
        public static void OpenNewZamanaKarsi()
        {
            Zamanakarsi frm = new Zamanakarsi();
            formoval(frm);
            frm.Show();
        }
       
        public static void OpenNewKelimeZamanaKarsiTurkce()
        {
            ZamanaKarsiTürkce frm = new ZamanaKarsiTürkce();
            formoval(frm);
            frm.Show();
        }
        public static void OpenNewKelimeBulma()
        {
            KelimeBulmaİngilizce frm = new KelimeBulmaİngilizce();
            formoval(frm);
            frm.Show();
        }
        public static void OpenNewKelimeBulmaTurkce()
        {
            KelimeBulmaTürkce frm = new KelimeBulmaTürkce();
            formoval(frm);
            frm.Show();
        }
        public static void OpenNewÖgrenciKelime()
        {
            ÖgrendigimKelimeler frm = new ÖgrendigimKelimeler();
            formoval(frm);
            frm.Show();
        }
        public static void formoval(Control frm)
        {
            Rectangle Bounds = new Rectangle(0, 0, frm.Width, frm.Height);
            int CornerRadius = 15;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);//sol üst
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);//sağ üst
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);//sağ alt
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);//sol alt
            path.CloseAllFigures();

           frm.Region = new Region(path);
        }
    }
}
