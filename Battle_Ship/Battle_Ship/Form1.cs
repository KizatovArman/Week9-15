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
        
        bool clicked;
        bool vertical, horizontal;
        bool ship1,ship2,ship3,ship4;
        int x;
        int y;
        int cntof1, cntof2, cntof3, cntof4;

        public Form1()
        {
            InitializeComponent();
            horizontal = true;
            vertical = false;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            clicked = false;
            ship1 = false;
            ship2 = false;
            ship3 = false;
            ship4 = false;

            Rectangle[,] fieldcomp = new Rectangle[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j <10; j++)
                {
                    fieldcomp[i, j] = new Rectangle();
                    fieldcomp[i, j].Size = new Size(40, 40);
                    fieldcomp[i, j].Location = new Point(15 + i * 35, 15 + j * 35);
                    g.DrawRectangle(new Pen(Color.Black), fieldcomp[i, j]);
                    
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
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
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
