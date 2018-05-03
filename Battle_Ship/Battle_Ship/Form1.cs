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
        Graphics g1,g2;
        Bitmap bmp1,bmp2;
        int x1, x2, x3, x4;
        bool clicked;
        bool vertical, horizontal;
        bool ship1,ship2,ship3,ship4;
        int x;
        int y;
        int cntof1, cntof2, cntof3, cntof4;

        public Form1()
        {
            x1 = 5;
            x2 = 4;
            x3 = 3;
            x4 = 2;
            InitializeComponent();
            horizontal = true;
            vertical = false;
            bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp1;
            g1 = Graphics.FromImage(bmp1);
            bmp2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = bmp2;
            g2 = Graphics.FromImage(bmp2);
            clicked = false;
            ship1 = false;
            ship2 = false;
            ship3 = false;
            ship4 = false;

            Rectangle[,] fielduser = new Rectangle[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j <10; j++)
                {
                    fielduser[i, j] = new Rectangle();
                    fielduser[i, j].Size = new Size(40, 40);
                    fielduser[i, j].Location = new Point(15 + i * 35, 15 + j * 35);
                    g1.DrawRectangle(new Pen(Color.Black), fielduser[i, j]);
                    
                }
            }

            Rectangle[,] fieldoponent = new Rectangle[10, 10];
            for(int i = 0; i < 10;i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    fieldoponent[i, j] = new Rectangle();
                    fieldoponent[i, j].Size = new Size(40, 40);
                    fieldoponent[i,j].Location = new Point(15 + i * 35, 15 + j * 35);
                    g2.DrawRectangle(new Pen(Color.Black), fieldoponent[i, j]);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            if(ship4)
            {
                Rectangle[,] rects = new Rectangle[10, 10];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        rects[j, i] = new Rectangle();
                        rects[j, i].Size = new Size(35, 35);
                        rects[j, i].Location = new Point(10 + j * 37, 10 + i * 37);
                        g1.DrawRectangle(new Pen(Color.Black), rects[j, i]);
                        if (rects[j, i].Contains(x, y) && clicked == true)
                        {
                            SolidBrush br = new SolidBrush(Color.Red);
                            g1.FillRectangle(br, rects[j, i]);
                            g1.FillRectangle(br, rects[j, i - 1]);
                            g1.FillRectangle(br, rects[j, i + 1]);
                        }
                    }
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                horizontal = true;
                vertical = false;
            }
            if(e.KeyCode == Keys.Up)
            {
                vertical = true;
                horizontal = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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
                    if (rects[j, i].Contains(x, y) && ship4 == true)
                    {

                        SolidBrush br = new SolidBrush(Color.Red);

                        e.Graphics.FillRectangle(br, rects[j, i]);
                        e.Graphics.FillRectangle(br, rects[j, i - 1]);
                        e.Graphics.FillRectangle(br, rects[j, i + 1]);
                        e.Graphics.FillRectangle(br, rects[j, i + 2]);
                    }


                }
            }
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ship4 = true;
            ship1 = false;
            ship2 = false;
            ship3 = false;
            x4--;
        }
    }
}
