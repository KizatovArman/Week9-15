using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasksofmidterm
{
    class Program
    {
        public static int Twotothen(int x)
        {
            int result = 1;
            for(int i = 1; i <= x; i++)
            {
                result = result * 2;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int x1=Twotothen(n);
            Console.WriteLine(x1 + "");
            Console.ReadKey();

        }
    }
}
