using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WindowsFormsApp2
{
   public partial class Form1 : Form
    {
       public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Pen p = new Pen(Color.Blue);
            //Point pt1 = new Point(100, 0);
            //Point pt2 = new Point(100, 300);
            //g.DrawLine(p, pt1, pt2);


            //Point pt3 = new Point(200, 0);
            //Point pt4 = new Point(200, 300);
            //g.DrawLine(p, pt3, pt4);

            //Point pt5 = new Point(0, 100);
            //Point pt6 = new Point(300, 100);
            //g.DrawLine(p, pt5, pt6);

            //Point pt7 = new Point(0, 200);
            //Point pt8 = new Point(300, 200);
            //g.DrawLine(p, pt7, pt8);

            ////Point[] points = new Point[10];

          
        }

       
        private void userControl11_Click(object sender, EventArgs e)
        {
            //System.Drawing.Graphics y;
            //y = this.CreateGraphics();

            //MouseEventArgs click1 = (MouseEventArgs)e;

            //if (click1.X < 100 && click1.Y < 100)
            //{
            //    if (player == true)
            //    {
            //        Point x11 = new Point(25, 25);
            //        Point x12 = new Point(75, 75);
            //        y.DrawLine(Pens.Red, x11, x12);
            //        player = false;
            //        array[0] = 1;

            //        MessageBox.Show("m;l");
            //    }
            //    else
            //    {

            //        y.DrawArc(Pens.Red, 25, 25, 50, 50, 0, 360);
            //        player = true;
            //        array[9] = 1;
            //    }
            //}
            //else if (click1.X < 200 && click1.X > 100 && click1.Y < 100)
            //{
            //    if (player == true)
            //    {
            //        Point x21 = new Point(125, 25);
            //        Point x22 = new Point(175, 75);
            //        y.DrawLine(Pens.Red, x21, x22);
            //        player = false;
            //        array[1] = 1;

            //    }
            //    else
            //    {

            //        y.DrawArc(Pens.Red, 25, 25, 50, 50, 0, 360);
            //        player = true;
            //        array[9] = 1;

            //    }
            //}
            //else if (click1.X < 300 && click1.X > 200 && click1.Y < 100)
            //{

            //}
            //else if (click1.X < 100 && click1.Y > 100 && click1.Y < 200)
            //{

            //}
            //else if (click1.X < 200 && click1.X > 100 && click1.Y > 100 && click1.Y < 200)
            //{

            //}
            //else if (click1.X < 300 && click1.X > 200 && click1.Y > 100 && click1.Y < 200)
            //{

            //}
            //else if (click1.X < 100 && click1.Y > 200 && click1.Y < 300)
            //{

            //}
            //else if (click1.X < 200 && click1.X > 100 && click1.Y > 200 && click1.Y < 300)
            //{

            //}
            //else if (click1.X < 300 && click1.X > 200 && click1.Y > 200 && click1.Y < 300)
            //{

            //}
        }

          
        
    }
}
