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
        int cnt = 0;
        int k = 0;
        bool canplay = true;
       
        List<Button> body = new List<Button>(); 
        public Form1()
        {
            InitializeComponent();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (cnt%5==0)
            { 
                int x1 = new Random().Next(1, Width - 60);
                Button btn = new Button();
                btn.Size = new Size(15, 15);
                btn.Location = new Point(x1, 0);
                btn.BackColor = Color.White;
                btn.Text = "!!!!";
                body.Add(btn);
                Controls.Add(btn);
                if(timer1.Interval>=40)
                {
                    timer1.Interval -= 5;
                }
            }
            else
            {
                
                for (int i = 1; i < body.Count(); i++)
                {
                    int y = body[i].Location.Y;
                    body[i].Location = new Point(body[i].Location.X, y + dy);
                    if (body[i].Location.Y == Height)
                        k++;
                }
            }
            cnt++;
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
                        label1.Location = new Point(Width, label1.Location.Y);
                    }
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.BackColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = k.ToString();
        }
    }
}
