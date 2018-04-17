using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath path;
        public Form1()
        {
            InitializeComponent();
            path = new GraphicsPath();
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 20),0,0,830,535);
            SolidBrush sb = new SolidBrush(Color.BlueViolet);
            SolidBrush sb1= new SolidBrush(Color.Green);
            Point[] p = new Point[8];
            p[0] = new Point(490, 200);
            p[1] = new Point(510, 195);
            p[2] = new Point(515, 175);
            p[3] = new Point(520, 195);
            p[4] = new Point(540, 200);
            p[5] = new Point(520, 205);
            p[6] = new Point(515, 225);
            p[7] = new Point(510, 205);
            e.Graphics.FillRectangle(sb, 10, 10, 810, 515);
            e.Graphics.DrawEllipse(new Pen(Color.White, 20), 60, 90, 20, 20);
            e.Graphics.DrawEllipse(new Pen(Color.White, 20), 90, 385, 20, 20);
            e.Graphics.DrawEllipse(new Pen(Color.White, 20), 360, 70, 20, 20);
            e.Graphics.DrawEllipse(new Pen(Color.White, 20), 370, 360, 20, 20);
            e.Graphics.DrawEllipse(new Pen(Color.White, 20), 730, 225, 20, 20);
            e.Graphics.DrawEllipse(new Pen(Color.White, 20), 745, 465, 20, 20);
            e.Graphics.DrawEllipse(new Pen(Color.White, 20), 625, 350, 20, 20);
            e.Graphics.DrawEllipse(new Pen(Color.White, 20), 520, 135, 20, 20);
            e.Graphics.FillPolygon(sb1,p);
            SolidBrush sb2 = new SolidBrush(Color.Yellow);
            Point[] p1 = new Point[3];
            p1[0] = new Point(410, 300);
            p1[1] = new Point(490, 300);
            p1[2] = new Point(450, 270);
            Point[] p2 = new Point[3];
            p2[0] = new Point(410, 350);
            p2[1] = new Point(490, 350);
            p2[2] = new Point(450, 380);
            e.Graphics.FillRectangle(sb2, 410, 300, 80, 50);
            e.Graphics.FillPolygon(sb2, p1);
            e.Graphics.FillPolygon(sb2, p2);
            Point[] p3 = new Point[3];
            p3[0] = new Point(430, 315);
            p3[1] = new Point(470, 315);
            p3[2] = new Point(450, 300);
            e.Graphics.FillRectangle(sb1, 440, 315, 20, 30);
            e.Graphics.FillPolygon(sb1, p3);
            SolidBrush sb3 = new SolidBrush(Color.Red);
            e.Graphics.FillRectangle(sb3, 120, 150, 20, 40);
            Point[] p4 = new Point[3];
            p4[0] = new Point(120, 150);
            p4[1] = new Point(140, 150);
            p4[2] = new Point(130, 140);
            e.Graphics.FillPolygon(sb3, p4);
            Point[] p5 = new Point[3];
            p5[0] = new Point(120, 190);
            p5[1] = new Point(140, 190);
            p5[2] = new Point(130, 200);
            e.Graphics.FillPolygon(sb3, p5);
            Point[] p6 = new Point[3];
            p6[0] = new Point(120, 150);
            p6[1] = new Point(110, 150);
            p6[2] = new Point(120, 170);
            e.Graphics.FillPolygon(sb3, p6);
            Point[] p7 = new Point[3];
            p7[0] = new Point(120, 190);
            p7[1] = new Point(110, 190);
            p7[2] = new Point(120, 170);
            e.Graphics.FillPolygon(sb3, p7);
            Point[] p8 = new Point[3];
            p8[0] = new Point(140, 150);
            p8[1] = new Point(150, 150);
            p8[2] = new Point(140, 170);
            e.Graphics.FillPolygon(sb3, p8);
            Point[] p9 = new Point[3];
            p9[0] = new Point(140, 170);
            p9[1] = new Point(140, 190);
            p9[2] = new Point(150, 190);
            e.Graphics.FillPolygon(sb3, p9);


        }
    }
}
