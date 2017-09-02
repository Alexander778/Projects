using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Week3_Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your path");
            string path = Console.ReadLine();
            Console.WriteLine("");

            try
            {
                ShowDirectory(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        public  static void ShowDirectory(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
            }
                

        }
    }
}
