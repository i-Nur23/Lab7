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
    class Rhomb : Square
    {
        private int height;

        public Rhomb() : base()
        {
            Random rand = new Random();
            height = rand.Next(20, 100);
            InitPoints();
        }

        public Rhomb(int x, int y, int width, int height) : base(x, y, width)
        {
            this.height = height;
            InitPoints();
        }

        protected override void InitPoints()
        {
            int halfWidth = len / 2;
            int halfHeight = height / 2;
            points[0] = new Point(x - halfWidth, y);
            points[1] = new Point(x, y - halfHeight);
            points[2] = new Point(x + halfWidth, y);
            points[3] = new Point(x, y + halfHeight);
        }
    }
}
