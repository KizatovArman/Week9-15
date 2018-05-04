using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tasksformidterm3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Test");
            int n = dir.GetFileSystemInfos().Length;
            FileSystemInfo[] fileSystemInfos = dir.GetFileSystemInfos();
            foreach(FileSystemInfo fs in fileSystemInfos)
            {
                StreamReader sr = new StreamReader(fs.FullName);
                string s1 = sr.ReadToEnd();
                if (s1.Contains("FIT")) 
                {
                    Console.WriteLine(fs.Name);
                }
                sr.Close();
            }
            Console.ReadKey(); 
        }
    }
}
