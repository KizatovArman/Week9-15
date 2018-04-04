using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        Calc calculator = new Calc();
        public double calcmemory = 0;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(textBox1.Text == "0" || textBox1.Text == "Error")
            {
                textBox1.Text = btn.Text;
            }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        private void Result_click(object sender, EventArgs e)
        {
            calculator.seconnumber = float.Parse(textBox1.Text);
            double x1 = calculator.seconnumber;
            calculator.Basicoperation();
            textBox1.Text = calculator.result + "";
            calculator.firstnumber=calculator.result;         
        }

        private void float_click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains(",") == false && textBox1.Text != "Error")
            {
                textBox1.Text += ",";
            }
        }

        private void delete_click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 1)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            else textBox1.Text = "0";
            
        }

        private void signature_click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text) * (-1)).ToString();
           
        }

        private void singleop_click(object sender, EventArgs e)
        {
            Button btn1 = sender as Button;
            calculator.operation = btn1.Text;
            calculator.firstnumber = double.Parse(textBox1.Text);
            calculator.Shortoperations();
            if (calculator.error != "")
            {
                textBox1.Text = calculator.error;
                calculator.error = "";
            }
            else
                textBox1.Text = calculator.result.ToString();          
        }

        private void manyvarop_click(object sender, EventArgs e)
        {
            Button btn4 = sender as Button;
            calculator.operation = btn4.Text;
            calculator.firstnumber = double.Parse(textBox1.Text);
           

                        
        }

        private void grandclear_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            calculator = new Calc();
        }

        private void Basicoperation_click(object sender, EventArgs e)
        {
            Button btn3 = sender as Button;
            calculator.firstnumber = float.Parse(textBox1.Text);
            calculator.operation = btn3.Text;
            textBox1.Text = "";
            
            calculator.Basicoperation();
        }
    }
}

