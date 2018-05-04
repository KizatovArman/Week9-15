using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace preparation1
{
    class Program
    {
        public static bool ISPrime(int x)
        {
            bool result = true;
            if(x==1 || x==0)
            {
                result = false;
            }
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    result = false;
                    break;
                }
                
             }
            return result;
        }

        static void Main(string[] args)
        {
            string str = System.IO.File.ReadAllText(@"C:\Users\ПК\Desktop\input.txt");

            string[] arr = str.Split('^');
            int maxi = int.Parse(arr[0]);
            foreach (string s in arr)
            {
                int ch1 = int.Parse(s);
                if (ch1 > maxi)
                {
                    if (ISPrime(ch1))
                        maxi = ch1;
                }
            }
            Console.WriteLine(maxi + "\n");
            Console.ReadKey();
        }
    }
}
