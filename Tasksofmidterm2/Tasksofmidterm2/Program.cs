using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tasksofmidterm2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\ПК\Desktop\input.txt");                            
            string s = sr.ReadToEnd();
            
            string[] arr = s.Split(' ');
           
            StreamWriter sw = new StreamWriter(@"C:\Users\ПК\Desktop\output.txt");
            string temp;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (int.Parse(arr[i]) > int.Parse(arr[j]))
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            
            sw.WriteLine(arr[1]);
            sw.WriteLine(arr[arr.Length - 2]);
            sr.Close();
            sw.Close();


        }
    }
}
