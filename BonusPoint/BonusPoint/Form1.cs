using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusPoint
{
    public partial class Form1 : Form
    {

        int dx = 15;
        int dy = 16;
        List<Button> body;
        public Form1()
        {
            InitializeComponent();
        }

        //body = new List<Button>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*int cnt = 0; 
            if (cnt%10==0)
            { 
                int x1 = new Random().Next(1, Width - 10);
                Button btn = new Button();
                btn.Size = new Size(10, 10);
                btn.Location = new Point(x1, 0);
                body.Add(btn);
            }
            else
            {
                
                for (int i = 1; i < body.Count(); i++)
                {
                    int y = body[i].Location.Y;
                    body[i].Location = new Point(x1, y + dy);
                }
            }
            cnt++;*/

            int cnt = 0;
            int ch1 = button1.Location.Y;
            button1.Location = new Point(button1.Location.X, button1.Location.Y + dy);
            if(button1.Location.Y == Height-1)
            {
                button1.Location = new Point(button1.Location.X, 1);
            }

            int ch2 = button2.Location.Y;
            button2.Location = new Point(button2.Location.X, button2.Location.Y + dy);
            if (button2.Location.Y == Height - 1)
            {
                button2.Location = new Point(button2.Location.X, 1);
            }

            int ch3 = button3.Location.Y;
            button3.Location = new Point(button3.Location.X, button3.Location.Y + dy);
            if (button3.Location.Y == Height - 1)
            {
                button3.Location = new Point(button3.Location.X, 1);
            }

            int ch4 = button4.Location.Y;
            button4.Location = new Point(button4.Location.X, button4.Location.Y + dy);
            if (button4.Location.Y == Height - 1)
            {
                button4.Location = new Point(button4.Location.X, 1);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
                int x = label1.Location.X;
                if (e.KeyCode == Keys.Right)
                {
                    x += dx;
                    label1.Location = new Point(x, label1.Location.Y);
                    if (x >= Width)
                    {
                        label1.Location = new Point(0, label1.Location.Y);
                    }
                }
                if(e.KeyCode == Keys.Left)
                {
                    x -= dx;
                    label1.Location = new Point(x, label1.Location.Y);
                    if (x <= 0)
                    {
                        label1.Location = new Point(Width-1, label1.Location.Y);
                    }
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
