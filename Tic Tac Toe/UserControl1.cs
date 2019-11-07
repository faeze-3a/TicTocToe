using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        int[] array = new int[18];
        bool player = true;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue);
            Point pt1 = new Point(100, 0);
            Point pt2 = new Point(100, 300);
            g.DrawLine(p, pt1, pt2);


            Point pt3 = new Point(200, 0);
            Point pt4 = new Point(200, 300);
            g.DrawLine(p, pt3, pt4);

            Point pt5 = new Point(0, 100);
            Point pt6 = new Point(300, 100);
            g.DrawLine(p, pt5, pt6);

            Point pt7 = new Point(0, 200);
            Point pt8 = new Point(300, 200);
            g.DrawLine(p, pt7, pt8);

        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics y;
            y = this.CreateGraphics();

            bool initturn = true;
            MouseEventArgs click1 = (MouseEventArgs)e;

            if (click1.X < 100 && click1.Y < 100)
            {
                if (player == true && array[9] != 1)
                {
                    Point x11 = new Point(25, 25);
                    Point x12 = new Point(75, 75);
                    y.DrawLine(Pens.Red, x11, x12);
                    y.DrawLine(Pens.Red, 75, 25, 25, 75);
                    player = false;
                    array[0] = 1;
                    CheckWin();

                }
                else if (array[0] != 1)
                {

                    y.DrawArc(Pens.Red, 25, 25, 50, 50, 0, 360);
                    player = true;
                    array[9] = 1;
                    CheckWin();
                }
            }
            else if (click1.X < 200 && click1.X > 100 && click1.Y < 100)
            {
                if (player == true && array[10] != 2)
                {
                    Point x21 = new Point(125, 25);
                    Point x22 = new Point(175, 75);
                    y.DrawLine(Pens.Red, x21, x22);

                    Point x23 = new Point(175, 25);
                    Point x24 = new Point(125, 75);
                    y.DrawLine(Pens.Red, x23, x24);
                    player = false;
                    array[1] = 2;
                    CheckWin();

                }
                else if (array[1] != 2)
                {

                    y.DrawArc(Pens.Red, 125, 25, 50, 50, 0, 360);
                    player = true;
                    array[10] = 2;
                    CheckWin();

                }
            }
            else if (click1.X < 300 && click1.X > 200 && click1.Y < 100)
            {
                if (player == true && array[11] != 3)
                {
                    y.DrawLine(Pens.Red, 225, 25, 275, 75);
                    y.DrawLine(Pens.Red, 275, 25, 225, 75);
                    player = false;
                    array[2] = 3;
                    CheckWin();
                }
                else if (array[2] != 3)
                {

                    y.DrawArc(Pens.Red, 225, 25, 50, 50, 0, 360);
                    player = true;
                    array[11] = 3;
                    CheckWin();

                }
            }
            else if (click1.X < 100 && click1.Y > 100 && click1.Y < 200)
            {
                if (player == true && array[12] != 4)
                {
                    y.DrawLine(Pens.Red, 75, 125, 25, 175);
                    y.DrawLine(Pens.Red, 25, 125, 75, 175);
                    player = false;
                    array[3] = 4;
                    CheckWin();

                }
                else if (array[3] != 4)
                {

                    y.DrawArc(Pens.Red, 25, 125, 50, 50, 0, 360);
                    player = true;
                    array[12] = 4;
                    CheckWin();

                }
            }
            else if (click1.X < 200 && click1.X > 100 && click1.Y > 100 && click1.Y < 200)
            {
                if (player == true && array[13] != 5)
                {
                    y.DrawLine(Pens.Red, 175, 125, 125, 175);
                    y.DrawLine(Pens.Red, 125, 125, 175, 175);
                    player = false;
                    array[4] = 5;
                    CheckWin();

                }
                else if (array[4] != 5)
                {

                    y.DrawArc(Pens.Red, 125, 125, 50, 50, 0, 360);
                    player = true;
                    array[13] = 5;
                    CheckWin();


                }
            }
            else if (click1.X < 300 && click1.X > 200 && click1.Y > 100 && click1.Y < 200)
            {
                if (player == true && array[14] != 6)
                {
                    y.DrawLine(Pens.Red, 225, 125, 275, 175);
                    y.DrawLine(Pens.Red, 275, 125, 225, 175);
                    player = false;
                    array[5] = 6;
                    CheckWin();

                }
                else if (array[5] != 6)
                {

                    y.DrawArc(Pens.Red, 225, 125, 50, 50, 0, 360);
                    player = true;
                    array[14] = 6;
                    CheckWin();


                }
            }
            else if (click1.X < 100 && click1.Y > 200 && click1.Y < 300)
            {
                if (player == true && array[15] != 7)
                {
                    y.DrawLine(Pens.Red, 25, 225, 75, 275);
                    y.DrawLine(Pens.Red, 75, 225, 25, 275);
                    player = false;
                    array[6] = 7;
                    CheckWin();

                }
                else if (array[6] != 7)
                {

                    y.DrawArc(Pens.Red, 25, 225, 50, 50, 0, 360);
                    player = true;
                    array[15] = 7;
                    CheckWin();


                }
            }
            else if (click1.X < 200 && click1.X > 100 && click1.Y > 200 && click1.Y < 300)
            {
                if (player == true && array[16] != 8)
                {
                    y.DrawLine(Pens.Red, 125, 225, 175, 275);
                    y.DrawLine(Pens.Red, 175, 225, 125, 275);
                    player = false;
                    array[7] = 8;
                    CheckWin();

                }
                else if (array[7] != 8)
                {

                    y.DrawArc(Pens.Red, 125, 225, 50, 50, 0, 360);
                    player = true;
                    array[16] = 8;
                    CheckWin();


                }
            }
            else if (click1.X < 300 && click1.X > 200 && click1.Y > 200 && click1.Y < 300)
            {
                if (player == true && array[17] != 9)
                {
                    y.DrawLine(Pens.Red, 225, 225, 275, 275);
                    y.DrawLine(Pens.Red, 275, 225, 225, 275);
                    player = false;
                    array[8] = 9;
                    CheckWin();

                }
                else if (array[8] != 9)
                {

                    y.DrawArc(Pens.Red, 225, 225, 50, 50, 0, 360);
                    player = true;
                    array[17] = 9;
                    CheckWin();


                }
            }
            

        }

        void CheckWin()
        {
            System.Drawing.Graphics L;
            L = CreateGraphics();

            if(player == false)
            {
                if (array[0] == 1 && array[1] == 2 && array[2] == 3 || array[3] == 4 && array[4] == 5 && array[5] == 6 || array[6] == 7 && array[7] == 8 && array[8] == 9 || array[0] == 1 && array[4] == 5 && array[8] == 9 || array[2] == 3 && array[4] == 5 && array[6] == 7 || array[0] == 1 && array[3] == 4 && array[6] == 7 || array[2] == 3 && array[5] == 6 && array[8] == 9 || array[1] == 2 && array[4] == 5 && array[7] == 8)
                {
                    MessageBox.Show("player X has won");
                    L.Clear(Color.White);
                    this.Invalidate();
                    Reset();
                }
            }
            if(player == true)
            {
                if(array[9] == 1 && array[10] == 2 && array[11] == 3 || array[12] == 4 && array[13] == 5 && array[14] == 6 || array[15] == 7 && array[16] == 8 && array[17] == 9 || array[9] == 1 && array[13] == 5 && array[17] == 9 || array[11] == 3 && array[13] == 5 && array[15] == 7 || array[9] == 1 && array[12] == 4 && array[15] == 7 || array[10] == 2 && array[13] == 5 && array[16] == 8 || array[11] == 3 && array[14] == 6 && array[17] == 9)
                
                {

                    MessageBox.Show("player O has won");
                    L.Clear(Color.White);
                    this.Invalidate();
                    Reset();
                }
                 
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    count++;
                }
            }
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Reset();
                this.Invalidate();
            }

            void Reset()
            {
                for (int i = 0; i < 18; i++)
                {
                    array[i] = 0;
                }
               
               
                this.Invalidate();
            }
        }
    }
}