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
    class FigureList
    {
        private Node head;
        private Node tail;
        private int length = 0;
        public FigureList()
        {

        }

        public FigureList(int length,ref string[] strs)
        {
            Random rand = new Random();
            this.length = length;
            Array.Resize(ref strs, length);
            for (int i = 0, circs = 0, sqrs = 0, rects = 0, ells = 0, rhombs = 0, trs = 0; i < length; i++)
            {
                switch (rand.Next(0, 6))
                {
                    case 0:
                        circs++;
                        Append(new Circle());
                        strs[i] = "Круг " + circs;
                        break;
                    case 1:
                        sqrs++;
                        Append(new Square());
                        strs[i] = "Квадрат " + sqrs;
                        break;
                    case 2:
                        rects++;
                        Append(new Rects());
                        strs[i] = "Прямоугольник " + rects;
                        break;
                    case 3:
                        ells++;
                        Append(new Ellipse());
                        strs[i] = "Эллипс " + ells;
                        break;
                    case 4:
                        rhombs++;
                        Append(new Rhomb());
                        strs[i] = "Ромб " + rhombs;
                        break;
                    case 5:
                        trs++;
                        Append(new Trapezoid());
                        strs[i] = "Трапеция " + trs;
                        break;
                }
            }
        }

        private void Append(TFigure figure)
        {
            Node node = new Node(figure);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
        }

        public void Show(PictureBox canvas, Bitmap bitmap)
        {
            Node p = head;
            
            for (int i = 0, circs = 0, sqrs = 0, rects = 0, ells = 0, rhombs = 0, trs = 0; i < length; i++)
            {
                TFigure figure = p.Figure;
                if (figure is Trapezoid trap)
                {
                    trs++;
                    trap.Show(trs, canvas, bitmap);
                }
                else if (figure is Rhomb rhomb)
                {
                    rhombs++;
                    rhomb.Show(rhombs, canvas, bitmap);
                }
                else if (figure is Ellipse ell)
                {
                    ells++;
                    ell.Show(ells, canvas, bitmap);
                }
                else if (figure is Rects rect)
                {
                    rects++;
                    rect.Show(rects, canvas, bitmap);
                }
                else if (figure is Square sqr)
                {
                    sqrs++;
                    sqr.Show(sqrs, canvas, bitmap);
                }
                else if (figure is Circle circ)
                {
                    circs++;
                    circ.Show(circs, canvas, bitmap);
                }
                
                p = p.Next;
            }
        }

        public void Add(ref string[] strs)
        {
            Random rand = new Random();
            switch (rand.Next(0, 6))
            {
                case 0:
                    Append(new Circle());
                    break;
                case 1:
                    Append(new Square());
                    break;
                case 2:
                    Append(new Rects());
                    break;
                case 3:
                    Append(new Ellipse());
                    break;
                case 4:
                    Append(new Rhomb());
                    break;
                case 5:
                    Append(new Trapezoid());
                    break;
            }
            
            length++;
            Array.Resize(ref strs,length);

            Node p = head;
            for (int i = 0, circs = 0, sqrs = 0, rects = 0, ells = 0, rhombs = 0, trs = 0; i < length; i++)
            {
                TFigure figure = p.Figure;
                if (figure is Trapezoid)
                {
                    trs++;
                    strs[i] = "Трапеция " + trs;
                }
                else if (figure is Rhomb)
                {
                    rhombs++;
                    strs[i] = "Ромб " + rhombs;
                }
                else if (figure is Ellipse)
                {
                    ells++;
                    strs[i] = "Эллипс " + ells;
                }
                else if (figure is Rects)
                {
                    rects++;
                    strs[i] = "Прямоугольник " + rects;
                }
                else if (figure is Square)
                {
                    sqrs++;
                    strs[i] = "Квадрат " + sqrs;
                }
                else if (figure is Circle)
                {
                    circs++;
                    strs[i] = "Круг " + circs;
                }
                p = p.Next;
            }
        }

        public void Erase(PictureBox canvas, Bitmap bitmap)
        {
            Node p = head;
            for (int i = 0; i < length; i++)
            {
                TFigure figure = p.Figure;
                figure.Delete(canvas, bitmap);
                p = p.Next;
            }
        }

        public void Move(PictureBox canvas, Bitmap bitmap, int dx, int dy)
        {
            Node p = head;
            for (int i = 0; i < length; i++)
            {
                TFigure figure = p.Figure;
                figure.ToMove(dx, dy, canvas, bitmap);
                p = p.Next; 
            }
        }

        public void Delete()
        {
            while (length != 0)
            {
                Node p = head;
                head = p.Next;
                p.Figure = null;
                p = null;
                length--;
            }
            length = 0;
            head = null;
            tail = null;
        }
    }
}