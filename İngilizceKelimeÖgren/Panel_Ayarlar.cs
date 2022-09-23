using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İngilizceKelimeÖgren
{
    static class Panel_Ayarlar
    {
        public static void Cikis_MouseEnter(Button x)
        {

            x.BackColor = Color.FromArgb(255, 15, 27);

            x.Image = Properties.Resources.icons8_close_16__2_;
        }
        public static void Cikis_MouseLeave(Button x)
        {
            x.BackColor = Color.Transparent;
            x.Image = Properties.Resources.icons8_close_16__1_;
        }




    }
}
