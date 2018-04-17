using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_attempt2
{
    public partial class Form1 : Form
    {
        double firstnumber = 0;
        double secondnumber = 0;
        double result = 0;
        string operation = "";
        double memory = 0;
        int t = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox1.Text = "0";
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn1 = sender as Button;
            
            double chislo = double.Parse(textBox1.Text);
            operation = btn1.Text;
            if(operation!="")
            {
                if(operation == "x")
                {
                    firstnumber = firstnumber * chislo;
                }
                if (operation == "/")
                {
                    firstnumber = firstnumber / chislo;
                }
                if (operation == "-")
                {
                    firstnumber = firstnumber - chislo;
                }
                if (operation == "+")
                {
                    firstnumber = firstnumber + chislo;
                }
                if(operation =="")
                {
                    firstnumber = chislo;
                    
                }
               
            }
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBox1.Text == "0" )
            {
                textBox1.Text = btn.Text;
            }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            secondnumber = double.Parse(textBox1.Text);
            if (operation == "x")
            {
                result = firstnumber * secondnumber;
            }
            if (operation == "/")
            {
                result = firstnumber / secondnumber;
            }
            if (operation == "+")
            {
                result = firstnumber + secondnumber;
            }
            if (operation == "-")
            {
                result = firstnumber - secondnumber;
            }
            textBox1.Text = result + "";
            

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 1)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            else
                textBox1.Text = "0";
        }

        private void TotalClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = 0 + "";
            firstnumber = 0;
            secondnumber = 0;
            result = 0;
            operation = "";
           
            
        }

        private void Ce_Click(object sender, EventArgs e)
        {
            if (secondnumber != 0)
            {
                secondnumber = 0;
            }
            textBox1.Text = 0 + "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Signature_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text) * (-1)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory + "";

        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void MemoryPlus_Click(object sender, EventArgs e)
        {
            memory = memory + double.Parse(textBox1.Text);
        }

        private void MemoryMinus_Click(object sender, EventArgs e)
        {
            memory = memory - double.Parse(textBox1.Text);
        }

        private void MemorySave_Click(object sender, EventArgs e)
        {
            memory = double.Parse(textBox1.Text);

        }

        private void FloatPoint_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",") == false && textBox1.Text != "Error")
            {
                textBox1.Text += ",";
            }
        }
    }
}
