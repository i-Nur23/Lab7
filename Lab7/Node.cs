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
    class Node
    {
        public TFigure Figure { get; set; }
        public Node Next { get; set; }

        public Node(TFigure figure)
        {
            Figure = figure;
        }
    }
}
