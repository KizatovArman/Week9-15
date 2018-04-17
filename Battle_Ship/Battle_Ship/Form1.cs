using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Ship
{
    public enum Ships
    {
      
        Shipsizeoffour,
        Shipsizeofthree,
        Shipsizeoftwo,
        Shipesizeofone
    }
    ;
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        bool Clicked;
        bool three;
        int x;
        int y;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            Clicked = false;
            three = false;

            Rectangle[,] rects = new Rectangle[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    rects[i, j] = new Rectangle();
                    rects[i, j].Size = new Size(35, 35);
                    rects[i, j].Location = new Point(10 + j * 37, 10 + i * 37);
                    g.DrawRectangle(new Pen(Color.Black), rects[i, j]);
                }
            }


        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Clicked = true;
            Rectangle[,] rects = new Rectangle[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    rects[j, i] = new Rectangle();
                    rects[j, i].Size = new Size(35, 35);
                    rects[j, i].Location = new Point(10 + j * 37, 10 + i * 37);
                    g.DrawRectangle(new Pen(Color.Black), rects[j, i]);
                    if (rects[j, i].Contains(x, y) && Clicked == true)
                    {
                        SolidBrush br = new SolidBrush(Color.Red);
                        g.FillRectangle(br, rects[j, i]);
                        g.FillRectangle(br, rects[j, i - 1]);
                        g.FillRectangle(br, rects[j, i + 1]);
                    }
                }
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            three = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle[,] rects = new Rectangle[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    rects[j, i] = new Rectangle();
                    rects[j, i].Size = new Size(35, 35);
                    rects[j, i].Location = new Point(10 + j * 37, 10 + i * 37);
                    e.Graphics.DrawRectangle(new Pen(Color.Black), rects[j, i]);
                    if (rects[j, i].Contains(x, y) && three == true)
                    {

                        SolidBrush br = new SolidBrush(Color.Red);

                        e.Graphics.FillRectangle(br, rects[j, i]);
                        e.Graphics.FillRectangle(br, rects[j, i - 1]);
                        e.Graphics.FillRectangle(br, rects[j, i + 1]);
                    }


                }
            }
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
