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

namespace last_paint
{

    public enum Tool
    {
        Pencil, Rectangle, Circle, Eraser, Fill
    }

    public partial class Form1 : Form
    {
        Color original;
        Color current;
        Color clr;
        Graphics g;
        Queue<Point> q;
        GraphicsPath path;
        Point prev;
        Bitmap bitmp;
        int size;
        Tool t;
        Pen pen;
        bool clicked;

        public Form1()
        {
            InitializeComponent();

            path = new GraphicsPath();
            bitmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmp;
            g = Graphics.FromImage(bitmp);
            g.Clear(Color.White);
            q = new Queue<Point>();
            t = Tool.Pencil;
            clr = Color.Black;
            pen = new Pen(clr, size);
            clicked = false;
            size = 1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(pen,path);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(clicked)
            {
                Point curr = e.Location;
                path.Reset();//reset everything in GraphicsPath
                if(t == Tool.Pencil)
                {
                    g.DrawLine(pen, prev, curr);
                    prev = curr;
                }
                if(t == Tool.Rectangle)
                {
                    int x = Math.Min(curr.X, prev.X);
                    int y = Math.Min(curr.Y, prev.Y);
                    int wr = Math.Abs(curr.X - prev.X);
                    int hr = Math.Abs(curr.Y - prev.Y);
                    path.AddRectangle(new Rectangle(x,y,wr,hr));
                }
                if(t == Tool.Circle)
                {
                    int x1 = Math.Min(curr.X, prev.X);
                    int y1 = Math.Min(curr.Y, prev.Y);
                    int we = Math.Abs(curr.X - prev.X);
                    int he = Math.Abs(curr.Y - prev.Y);
                    path.AddEllipse(x1, y1, we,he);
                }
                
                pictureBox1.Refresh();//call paint function which redraws picturebox
            }
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            //if graphicspath is not empty draw last position of the shape in bitmap
            if (path != null)
                g.DrawPath(pen, path);
        }

        private void tool_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Name =="Circle")
            {
                t = Tool.Circle;
            }
            if(btn.Name == "Pencil")
            {
                t = Tool.Pencil;
            }
            if(btn.Name=="Rectangle")
            {
                t = Tool.Rectangle;
            }
            if(btn.Name =="Eraser")
            {
                t = Tool.Eraser;
            }
            if(btn.Name=="Fill")
            {
                t = Tool.Fill;
            }
        }
        public void Step(int x, int y)
        {
            if (x >= bitmp.Width)
                return;
            if (x < 0)
                return;
            if (y < 0)
                return;
            if (y >= bitmp.Height)
                return;
            if (bitmp.GetPixel(x, y) != original)
                return;
            bitmp.SetPixel(x, y, current);
            q.Enqueue(new Point(x, y));
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
            if(t == Tool.Fill)
            {
                q.Enqueue(e.Location);
                original = bitmp.GetPixel(e.X, e.Y);
                current = clr;
                while (q.Count > 0)
                {
                    int x = q.First().X;
                    int y = q.First().Y;
                    q.Dequeue();
                    Step(x + 1, y);
                    Step(x - 1, y);
                    Step(x, y + 1);
                    Step(x, y - 1);
                }
            }
            pictureBox1.Image = bitmp;
        }

        private void clolor_click(object sender, EventArgs e)
        {
            Button btn1 = sender as Button;
            
            pen = new Pen(btn1.BackColor, size);
            clr = btn1.BackColor;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = trackBar1.Value;
            pen = new Pen(clr, size);
        }
    }
}
