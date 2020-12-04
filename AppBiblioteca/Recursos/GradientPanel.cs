using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBiblioteca.Recursos
{
    class GradientPanel : Panel
    {

        public Color ColorUP { get; set; }
        public Color ColorDown { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush pincel = new LinearGradientBrush(this.ClientRectangle, this.ColorUP, this.ColorDown, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(pincel, this.ClientRectangle);
            base.OnPaint(e);
        }

    }
}
