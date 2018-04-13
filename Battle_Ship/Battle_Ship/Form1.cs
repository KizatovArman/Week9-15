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
        Ships ships;
        bool clicked;
        int coordinatex;
        int coordinatey;
        Point prev, cur;
        bool can_draw4, can_draw3, can_draw2, can_draw1;
        Graphics g;
        int kolvo4;
        int kolvo3;
        int kolvo2;
        int kolvo1;
        
        
        public Form1()
        {

            ships = Ships.Shipsizeoffour;
            InitializeComponent();
            g = CreateGraphics();
            kolvo1 = 5;
            kolvo2 = 4;
            kolvo3 = 3;
            kolvo4 = 2;
            clicked = false;
            can_draw1 = true;
            can_draw2 = true;
            can_draw3 = true;
            can_draw4 = true;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            coordinatex = e.X;
            coordinatey = e.Y;
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ships = Ships.Shipsizeofthree;
            if (kolvo3 != 0 && can_draw3 == true)
            {
                kolvo3--;
            }
            if (kolvo3 == 0)
                can_draw3 = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ships = Ships.Shipsizeoftwo;
            if (kolvo2 != 0 && can_draw2 == true)
            {
                kolvo2--;
            }
            if (kolvo2 == 0)
                can_draw2 = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ships = Ships.Shipesizeofone;
            if (kolvo1 != 0 && can_draw1 == true)
            {
                kolvo1--;
            }
            if (kolvo1 == 0)
                can_draw1 = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(clicked && can_draw4)
            {
                cur = e.Location;
                
            }
            if (clicked && can_draw3)
            {
                cur = e.Location;
                

            }
            if (clicked && can_draw2)
            {
                cur = e.Location;
               
            }
            if (clicked && can_draw1)
            {
                cur = e.Location;
                
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), 30*i + 30, 30*j + 30, 30*j + 30, 30*i + 30);   
                }
            }

            if (clicked && can_draw4 && ships == Ships.Shipsizeoffour)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex, coordinatey, 30,  30);
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex+30, coordinatey, 30, 30);
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex + 60, coordinatey , 30, 30);
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex + 90, coordinatey , 30, 30);
            }

            if (clicked && can_draw3 && ships == Ships.Shipsizeofthree)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex, coordinatey, 30, 30);
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex + 30, coordinatey, 30, 30);
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex + 60, coordinatey, 30, 30);
            }

            if (clicked && can_draw2 && ships == Ships.Shipsizeoftwo)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex, coordinatey, 30, 30);
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex + 30, coordinatey, 30, 30);
                
            }
            if (clicked && can_draw1 && ships == Ships.Shipesizeofone)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), coordinatex, coordinatey, 30, 30);
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ships = Ships.Shipsizeoffour;
            if(kolvo4!=0 &&can_draw4==true)
            {
                kolvo4--;
            }
            if (kolvo4 == 0)
                can_draw4 = false;
        }
    }
}
