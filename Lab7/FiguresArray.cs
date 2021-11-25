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
    class FiguresArray
    {
        private TFigure[] array;
        private int length = 0;
        public FiguresArray()
        {
            array = new TFigure[0];
        }

        public FiguresArray(int length, ref string[] strs)
        {
            this.length = length;
            array = new TFigure[length];
            Random rand = new Random();
            Array.Resize(ref strs, length);
            for (int i = 0, circs = 0, sqrs = 0, rects = 0, ells = 0, rhombs = 0, trs = 0; i < length; i++)
            {
                switch (rand.Next(0, 6))
                {
                    case 0:
                        circs++;
                        array[i] = new Circle();
                        strs[i] = "Круг " + circs;
                        break;
                    case 1:
                        sqrs++;
                        array[i] = new Square();
                        strs[i] = "Квадрат " + sqrs;
                        break;
                    case 2:
                        rects++;
                        array[i] = new Rects();
                        strs[i] = "Прямоугольник " + rects;
                        break;
                    case 3:
                        ells++;
                        array[i] = new Ellipse();
                        strs[i] = "Эллипс " + ells;
                        break;
                    case 4:
                        rhombs++;
                        array[i] = new Rhomb();
                        strs[i] = "Ромб " + rhombs;
                        break;
                    case 5:
                        trs++;
                        array[i] = new Trapezoid();
                        strs[i] = "Трапеция " + trs;
                        break;
                }
            }
        }

        public void Show(PictureBox canvas, Bitmap bitmap)
        {
            for (int i = 0, circs = 0, sqrs = 0, rects = 0, ells = 0, rhombs = 0, trs = 0; i < length; i++)
            {
                if (array[i] is Trapezoid trap)
                {
                    trs++;
                    trap.Show(trs, canvas, bitmap);
                }
                else if (array[i] is Rhomb rhomb)
                {
                    rhombs++;
                    rhomb.Show(rhombs, canvas, bitmap);
                }
                else if (array[i] is Ellipse ell)
                {
                    ells++;
                    ell.Show(ells, canvas, bitmap);
                }
                else if (array[i] is Rects rect)
                {
                    rects++;
                    rect.Show(rects, canvas, bitmap);
                }
                else if (array[i] is Square sqr)
                {
                    sqrs++;
                    sqr.Show(sqrs, canvas, bitmap);
                }
                else if (array[i] is Circle circ)
                {
                    circs++;
                    circ.Show(circs, canvas, bitmap);
                }
            }
        }

        public void Erase(PictureBox canvas, Bitmap bitmap)
        {
            for (int i = 0; i < length; i++)
            {
                array[i].Delete(canvas,bitmap);
            }
        }

        public void Move(PictureBox canvas, Bitmap bitmap, int dx, int dy)
        {
            for (int i = 0; i < length; i++)
            {
                array[i].ToMove(dx,dy,canvas, bitmap);
            }
        }

        public void Add(ref string[] strs)
        {
            Array.Resize(ref array, length + 1);
            Array.Resize(ref strs, length + 1);
            Random rand = new Random();
            TFigure figure;
            switch (rand.Next(0, 6))
            {
                case 0:
                    figure = new Circle();
                    break;
                case 1:
                    figure = new Square();
                    break;
                case 2:
                    figure = new Rects();
                    break;
                case 3:
                    figure = new Ellipse();
                    break;
                case 4:
                    figure = new Rhomb();
                    break;
                case 5:
                    figure = new Trapezoid();
                    break;
                default:
                    figure = new Circle();
                    break;
            }
            array[length] = figure;
            length++;
            for (int i = 0, circs = 0, sqrs = 0, rects = 0, ells = 0, rhombs = 0, trs = 0; i < length; i++)
            {
                if (array[i] is Trapezoid)
                {
                    trs++;
                    strs[i] = "Трапеция " + trs;
                }
                else if (array[i] is Rhomb)
                {
                    rhombs++;
                    strs[i] = "Ромб " + rhombs;
                }
                else if (array[i] is Ellipse)
                {
                    ells++;
                    strs[i] = "Эллипс " + ells;
                }
                else if (array[i] is Rects)
                {
                    rects++;
                    strs[i] = "Прямоугольник " + rects;
                }
                else if (array[i] is Square)
                {
                    sqrs++;
                    strs[i] = "Квадрат " + sqrs;
                }
                else if (array[i] is Circle)
                {
                    circs++;
                    strs[i] = "Круг " + circs;
                }
            }
        }

        public void Delete()
        {
            Array.Clear(array,0,length);
            array = null;
            length = 0;
        }
    }
}
