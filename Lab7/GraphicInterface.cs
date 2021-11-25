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
    public partial class GraphicInterface : Form
    {
        Bitmap bitmap;
        string[] strs = new string[0];
        int length = 20;
        int choice = 0;
        Random rand = new Random();
        FiguresArray FigsArr;
        FigureList FigsList;

        public GraphicInterface()
        {
            InitializeComponent();
            bitmap = new Bitmap(canvas.Width, canvas.Height);
        }

        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((textBoxX.Text.Length != 0) && (number == 45))
            {
                e.Handled = true;
            }

            if (!(Char.IsDigit(number)) && (number != 8) && (number != 45))
            {
                e.Handled = true;
            }
        }

        private void textBoxY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((textBoxY.Text.Length != 0) && (number == 45))
            {
                e.Handled = true;
            }

            if (!(Char.IsDigit(number)) && (number != 8) && (number != 45))
            {
                e.Handled = true;
            }
        }

        private void ChooseArray_Click(object sender, EventArgs e)
        {
            choice = 1;
            CreateEmpty.Enabled = true;
            Create20.Enabled = true;
            ChooseArray.Enabled = false;
            ChooseList.Enabled = false;
        }

        private void ChooseList_Click(object sender, EventArgs e)
        {
            choice = 2;
            CreateEmpty.Enabled = true;
            Create20.Enabled = true;
            ChooseArray.Enabled = false;
            ChooseList.Enabled = false;
        }

        private void CreateEmpty_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    FigsArr = new FiguresArray();
                    break;
                case 2:
                    FigsList = new FigureList();
                    break;
                default:
                    break;
            }
            CreateEmpty.Enabled = false;
            Create20.Enabled = false;
            AddOne.Enabled = true;
            showFigs.Enabled = true;
            deleteContainer.Enabled = true;
        }

        private void Create20_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    FigsArr = new FiguresArray(length,ref strs);
                    break;
                case 2:
                    FigsList = new FigureList(length,ref strs);
                    break;
                default:
                    break;
            }
            listOfFigures.Items.Clear();
            listOfFigures.Items.AddRange(strs);
            CreateEmpty.Enabled = false;
            Create20.Enabled = false;
            AddOne.Enabled = true;
            showFigs.Enabled = true;
            deleteContainer.Enabled = true;
        }

        private void showFigs_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    FigsArr.Show(canvas, bitmap);
                    break;
                case 2:
                    FigsList.Show(canvas,bitmap);
                    break;
                default:
                    break;
            }
            MoveFigs.Enabled = true;
            eraseFigs.Enabled = true;
            deleteContainer.Enabled = false;
        }

        private void AddOne_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    FigsArr.Add(ref strs);
                    break;
                case 2:
                    FigsList.Add(ref strs);
                    break;
                default:
                    break;
            }
            listOfFigures.Items.Clear();
            listOfFigures.Items.AddRange(strs);
        }

        private void eraseFigs_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    FigsArr.Erase(canvas,bitmap);
                    break;
                case 2:
                    FigsList.Erase(canvas,bitmap);
                    break;
                default:
                    break;
            }
            MoveFigs.Enabled = false;
            eraseFigs.Enabled = false;
            deleteContainer.Enabled = true;
        }

        private void MoveFigs_Click(object sender, EventArgs e)
        {
            int dx, dy;
            if (textBoxX.Text != string.Empty && textBoxY.Text != string.Empty)
            {
                dx = int.Parse(textBoxX.Text);
                dy = int.Parse(textBoxY.Text);
            }

            else if (textBoxX.Text == string.Empty && textBoxY.Text == string.Empty)
            {
                return;
            }

            else if (textBoxX.Text == string.Empty)
            {
                dx = 0;
                dy = int.Parse(textBoxY.Text);
            }

            else
            {
                dx = int.Parse(textBoxX.Text);
                dy = 0;
            }
          
            switch (choice)
            {
                case 1:
                    FigsArr.Move(canvas, bitmap, dx, dy);
                    FigsArr.Show(canvas, bitmap);
                    break;
                case 2:
                    FigsList.Move(canvas, bitmap, dx, dy);
                    FigsList.Show(canvas, bitmap);
                    break;
                default:
                    break;
            }
        }

        private void deleteContainer_Click(object sender, EventArgs e)
        {
            listOfFigures.Items.Clear();
            switch (choice)
            {
                case 1:
                    FigsArr.Delete();
                    FigsArr = null;
                    break;
                case 2:
                    FigsList.Delete();
                    FigsList = null;
                    break;
                default:
                    break;
            }
            AddOne.Enabled = false;
            showFigs.Enabled = false;
            deleteContainer.Enabled = false;
            ChooseArray.Enabled = true;
            ChooseList.Enabled = true;
        }
    }
}