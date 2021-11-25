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
    abstract class TFigure
    {
        protected int index;

        public int x { get; set; }
        public int y { get; set; }

        protected TFigure()
        {
            Random rand = new Random();
            x = rand.Next(100, 900);
            y = rand.Next(100, 500);
        }

        protected TFigure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Show(int index, PictureBox canvas, Bitmap bmp)
        {
            this.index = index;
            DrawDarkBlue(canvas, bmp);
        }

        protected abstract void DrawWhite(PictureBox canvas,Bitmap bmp);
        protected abstract void DrawDarkBlue(PictureBox canvas, Bitmap bmp);

        public void ToMove(int dx, int dy, PictureBox canvas, Bitmap bmp)
        {
            DrawWhite(canvas, bmp);

            x += dx;
            y += dy;

            Show(index,canvas,bmp);
        }

        public void Delete(PictureBox canvas, Bitmap bmp)
        {
            DrawWhite(canvas, bmp);
        }
    }
}
