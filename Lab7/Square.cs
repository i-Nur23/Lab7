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
    class Square : TFigure
    {
        protected int len;
        protected Point[] points = new Point[4];
        
        public Square() : base()
        {
            Random rand = new Random();
            len = rand.Next(20, 100);
        }

        public Square(int x, int y, int len) : base(x,y)
        {
            this.len = len;
        }

        protected virtual void InitPoints()
        {
            int halfLen = len / 2;
            points[0] = new Point(x - halfLen, y - halfLen);
            points[1] = new Point(x + halfLen, y - halfLen);
            points[2] = new Point(x + halfLen, y + halfLen);
            points[3] = new Point(x - halfLen, y + halfLen);
        }

        protected override void DrawDarkBlue(PictureBox canvas, Bitmap bmp)
        {
            Graphics gr = Graphics.FromImage(bmp);
            Pen mypen = new Pen(Color.Black, 2);
            SolidBrush fill = new SolidBrush(Color.DarkBlue);
            gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            gr.DrawPolygon(mypen, points);
            gr.FillPolygon(fill, points);
            gr.DrawString(Convert.ToString(index), new Font("Arial", 10), Brushes.Black, x - 3, y- 3);
            canvas.Image = bmp;
        }

        protected override void DrawWhite(PictureBox canvas, Bitmap bmp)
        {
            Graphics gr = Graphics.FromImage(bmp);
            Pen mypen = new Pen(Color.White, 2);
            SolidBrush fill = new SolidBrush(Color.White);
            gr.DrawPolygon(mypen, points);
            gr.FillPolygon(fill, points);
            gr.DrawString(Convert.ToString(index), new Font("Arial", 10), Brushes.White, x - 3, y - 3);
            canvas.Image = bmp;
        }

        public override void Show(int index, PictureBox canvas, Bitmap bmp)
        {
            InitPoints();
            this.index = index;
            DrawDarkBlue(canvas, bmp);
        }
    }
}
