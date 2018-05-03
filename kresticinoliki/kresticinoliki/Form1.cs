using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kresticinoliki
{
    public partial class Form1 : Form
    {
        bool playerturn;
        bool aiturn;
        bool choiceclicked;
        string text1, text2;
        Button[,] buttons = new Button[3, 3];
        public Form1()
        {
            InitializeComponent();
            playerturn = true;
            aiturn = false;
            text1 = ".";
            text2 = ";";
            choiceclicked = false;
            
            
            for(int i = 0;i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(75, 75);
                    btn.Location = new Point(185 + i * 75, 185 + j * 75);
                    btn.BackColor = Color.Blue;
                    btn.Click += game_click;
                    buttons[i, j] = btn;
                    Controls.Add(btn);
                }
            }
        }

        private void game_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (playerturn)
            {
                btn.Text = text1;
                playerturn = false;
                aiturn = true;
            }
            if(aiturn)
            {
                Random r1 = new Random();
                int x1 = r1.Next(0, 3);
                Random r2 = new Random();
                int x2 = r2.Next(0, 3);
                buttons[x1, x2].Text = text2;
                aiturn = false;
                playerturn = true;
            }
        }

        private void signchoice_click(object sender, EventArgs e)
        {
            playerturn = true;
            aiturn = false;
            choiceclicked = true;
            text1 = "X";
            text2 = "O";

        }

        private void start_click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void signchoice2_click(object sender, EventArgs e)
        {
            playerturn = false;
            aiturn = true;
            choiceclicked = true;
            text1 = "O";
            text2 = "X";
        }
        
    }
}
