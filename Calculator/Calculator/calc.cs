using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calc
    {
        public double firstnumber;
        public double seconnumber;
        public double prevnumber;
        public string prevoperation;
        public double result;
        public string operation;
        public string error;

        public Calc()
        {
            prevnumber = 0;
            prevoperation = "";
            firstnumber = 0;
            seconnumber = 0;
            result = 0;
            operation = "";
            error = "";
        }

        

        public void Shortoperations()
        {
            switch(operation)
            {
                case "1/x":
                    if (firstnumber != 0)
                        result = 1 / firstnumber;
                    else
                        error = "Error";
                    break;
                case "x^2":
                    result = firstnumber * firstnumber;
                    break;
                case "10^x":
                    result = Math.Pow(10, firstnumber);
                    break;
                case "e^x":
                    result = Math.Exp(firstnumber);
                    break;
                case "sinx":
                    result = Math.Sin(firstnumber);
                    break;
                case "cosx":
                    result = Math.Cos(firstnumber);
                    break;
                case "tanx":
                    if (Math.Cos(firstnumber) != 0)
                        result = Math.Tan(firstnumber);
                    else
                        error = "Error";
                    break;
                case "lnx":
                    if (firstnumber > 0)
                        result = Math.Log10(firstnumber);
                    else
                        error = "Error";
                    break;
                case "sqrt":
                    if (firstnumber >= 0)
                        result = Math.Sqrt(firstnumber);
                    else
                        error = "Error";
                    break;
                case "!":
                    if (firstnumber >= 0)
                        result = Factorial((int)firstnumber);
                    else
                        error = "Error";
                    break;

            }
        }
        int Factorial(int a)
        {
            if (a != 1)
                return a * Factorial(a - 1);
            else if (a == 0)
                return 1;
            else
                return 1;
        }
       
        public void Basicoperation()
        {
            switch(operation)
            {
                case "+":
                    result = firstnumber + seconnumber;
                    firstnumber = result;
                    prevnumber = seconnumber;
                    operation = "+";
                    break;
                case "-":
                    result = firstnumber - seconnumber;
                    firstnumber = result;
                    prevnumber = seconnumber;
                    operation = "-";
                    break;
                case "X":
                    result = firstnumber * seconnumber;
                    firstnumber = result;
                    prevnumber = seconnumber;
                    operation = "X";
                    break;
                case "/":
                    if (seconnumber != 0)
                    {
                        result = firstnumber / seconnumber;
                        firstnumber = result;
                        prevnumber = seconnumber;
                        operation = "/";
                    }
                    else
                        error = "Error";
                    break;
            }
        }

        public void Complexoperations()
        {
            switch(operation)
            {
                case "x^y":
                    if (seconnumber > 0)
                    {
                        result = Math.Pow(firstnumber, seconnumber);
                    }
                    if (seconnumber == 0)
                        result = 1;
                    break;

                case "mod":
                    result = firstnumber % seconnumber;
                    break;
                case "(sqrtx)^y":
                    if (seconnumber % 2 == 0 && firstnumber < 0)
                        error = "Error";
                    else
                        result = Math.Pow(firstnumber, 1 / seconnumber);
                    break;
            }
        }
    }
}
