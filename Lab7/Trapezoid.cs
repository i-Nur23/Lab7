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
    class Trapezoid : Square
    {
        private int height, lowerLen;

        public Trapezoid() : base()
        {
            Random rand = new Random();
            height = rand.Next(20, 100);
            lowerLen = rand.Next(20, 100);
            InitPoints();
        }

        public Trapezoid(int x, int y, int upperLen, int height, int lowerLen) : base(x, y, upperLen)
        {
            this.height = height;
            this.lowerLen = lowerLen;
            InitPoints();
        }

        protected override void InitPoints()
        {
            int halfUp = len / 2;
            int halfDown = lowerLen / 2;
            int halfHeight = height / 2;
            points[0] = new Point(x - halfUp, y - halfHeight);
            points[1] = new Point(x + halfUp, y - halfHeight);
            points[2] = new Point(x + halfDown, y + halfHeight);
            points[3] = new Point(x - halfDown, y + halfHeight);
        }
    }
}
