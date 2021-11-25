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
    class Rects : TFigure
    {

        private int width, height;
        
        public Rects() : base()
        {
            Random rand = new Random();
            width = rand.Next(20, 100);
            height = rand.Next(20,100);
        }

        public Rects(int x, int y, int width, int height) : base(x,y)
        {
            this.width = width;
            this.height = height;
        }

        protected override void DrawDarkBlue(PictureBox canvas, Bitmap bmp)
        {
            Graphics gr = Graphics.FromImage(bmp);
            Pen mypen = new Pen(Color.Red, 2);
            SolidBrush fill = new SolidBrush(Color.DarkBlue);
            gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            gr.DrawRectangle(mypen, x - (float)width / 2, y - (float)height / 2, width, height);
            gr.FillRectangle(fill, x - (float)width / 2, y - (float)height / 2, width, height);
            gr.DrawString(Convert.ToString(index), new Font("Arial", 10), Brushes.Black, x - width / 4, y - height / 4);
            canvas.Image = bmp;
        }

        protected override void DrawWhite(PictureBox canvas, Bitmap bmp)
        {
            Graphics gr = Graphics.FromImage(bmp);
            Pen mypen = new Pen(Color.White, 2);
            SolidBrush fill = new SolidBrush(Color.White);
            gr.DrawRectangle(mypen, x - (float)width / 2, y - (float)height / 2, width, height);
            gr.FillRectangle(fill, x - (float)width / 2, y - (float)height / 2, width, height);
            gr.DrawString(Convert.ToString(index), new Font("Arial", 10), Brushes.White, x - width / 4, y - height / 4);
            canvas.Image = bmp;
        }

        public void ChangeSides(int newWidth, int newHeight, PictureBox canvas, Bitmap bmp)
        {
            DrawWhite(canvas, bmp);

            width = newWidth;
            height = newHeight;

            DrawDarkBlue(canvas, bmp);
        }
    }
}