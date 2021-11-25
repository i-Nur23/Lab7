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
    class Circle : TFigure
    {
        protected int radius,verticalRadius;

        public Circle() : base()
        {
            Random rand = new Random();
            radius = rand.Next(10,50);
            verticalRadius = radius;
        }

        public Circle(int x, int y, int radius) : base(x,y)
        {
            this.radius = radius;
            verticalRadius = radius;
        }

        protected override void DrawDarkBlue(PictureBox canvas, Bitmap bmp)
        {
            Graphics gr = Graphics.FromImage(bmp);
            Pen mypen = new Pen(Color.Black, 2);
            SolidBrush fill = new SolidBrush(Color.DarkBlue);
            gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            gr.DrawEllipse(mypen, x - radius, y - verticalRadius, 2 * radius, 2 * verticalRadius);
            gr.FillEllipse(fill, x - radius, y - verticalRadius, 2 * radius, 2 * verticalRadius);
            gr.DrawString(Convert.ToString(index), new Font("Arial", 10), Brushes.Black, x - 5, y - 5);
            canvas.Image = bmp;
        }

        protected override void DrawWhite(PictureBox canvas, Bitmap bmp)
        {
            Graphics gr = Graphics.FromImage(bmp);
            Pen mypen = new Pen(Color.White, 2);
            SolidBrush fill = new SolidBrush(Color.White);
            gr.DrawEllipse(mypen, x - radius, y - verticalRadius, 2 * radius, 2 * verticalRadius);
            gr.FillEllipse(fill, x - radius, y - verticalRadius, 2 * radius, 2 * verticalRadius);
            gr.DrawString(Convert.ToString(index), new Font("Arial", 10), Brushes.White, x - 5, y - 5);
            canvas.Image = bmp;
        }
    }
}
