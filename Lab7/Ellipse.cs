using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    class Ellipse : Circle
    {
        public Ellipse() : base()
        {
            Random rand = new Random();
            verticalRadius = rand.Next(10, 50);
        }

        public Ellipse(int x, int y, int radius, int verticalRadius) : base(x,y,radius)
        {
            this.verticalRadius = verticalRadius;
        }

        public void changeOrientation(PictureBox canvas, Bitmap bmp)
        {
            DrawWhite(canvas, bmp);

            int item = radius;
            radius = verticalRadius;
            verticalRadius = item;

            DrawDarkBlue(canvas,bmp);
        }
    }
}
