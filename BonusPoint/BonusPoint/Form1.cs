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

        int dx = 20;//перемещение нашего игрока 
        int dy = 16;//перемещение наших кубиков
        int cnt = 0;
        int k = 0;//счетчик для очков
        List<Button> body = new List<Button>();//лист из наших кнопок которые будут падать
        public Form1()
        {
            InitializeComponent();
        }

        

        bool Collisionwithlabel()// метод для того чботы проверить столкновение игрока и кнопки, рассматриваем четыре случаю
        {
            int xlabelloca = label1.Location.X;// переменные чтобы не писать длинный код
            int ylabelloca = label1.Location.Y;
            int w = label1.Width;
            for (int i = 0; i < body.Count; i++)
            {
                int x1 = body[i].Location.X;//переменные чтобы не писать длинный код
                int y1 = body[i].Location.Y;
                int w1 = body[i].Width;
                if (xlabelloca > x1 && ylabelloca > y1)
                {
                    if (ylabelloca + w - y1 < w + w1 && xlabelloca + w - x1 < w + w1)
                    {
                        return true;
                    }
                }
                if (xlabelloca < x1 && ylabelloca > y1)
                {
                    if (ylabelloca + w - y1 < w + w1 && x1 + w1 - xlabelloca < w + w1)
                    {
                        return true;
                    }
                }
                if (xlabelloca > x1 && ylabelloca < y1)
                {
                    if (y1 + w1 - ylabelloca < w + w1 && xlabelloca + w - x1 < w + w1)
                    {
                        return true;
                    }
                }
                if (xlabelloca < x1 && ylabelloca < y1)
                {
                    if (y1 + w1 - ylabelloca < w + w1 && x1 + w1 - xlabelloca < w + w1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cnt%5==0)
            { 
                int x1 = new Random().Next(1, Width - 60);// задаем координату для кнопопк по иксу, рандомную
                Button btn = new Button();// создаем и добавляем кнопку в наш список 
                btn.Size = new Size(24, 24);
                btn.Enabled = false;
                btn.Location = new Point(x1, 0);
                btn.BackColor = Color.White;
                btn.Text = "!!!!";
                body.Add(btn);
                Controls.Add(btn);
                label2.Text = k.ToString();//наш счеткич скора
                if (timer1.Interval>=30)//ускоряем нашу игру пока наш интервал нашего таймера больше или равен 30
                {
                    timer1.Interval -= 5;
                }
            }
            else// проверка на столкновение 
            {
                if (Collisionwithlabel())
                {
                    timer1.Stop();
                    MessageBox.Show("GAME OVER");
                }
                
                for (int i = 1; i < body.Count(); i++)//пока идет таймер все кнопки на экране падают
                {
                    int y = body[i].Location.Y;
                    body[i].Location = new Point(body[i].Location.X, y + dy);
                   
                }
            }
            cnt++;
            k++;
        }
        private void label1_Click(object sender, EventArgs e){}
        private void Form1_KeyDown(object sender, KeyEventArgs e)//на нажатие стрелочек
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
            
        }
    }
}
