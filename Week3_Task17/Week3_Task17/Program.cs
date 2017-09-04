using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Week3_Task17
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

        public static void ShowDirectory(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo file = new DirectoryInfo(path);
            Console.WriteLine("Directories:");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
                
            }
            Console.WriteLine("");
            Console.WriteLine("Files:");
            foreach (var item in dir.GetFiles())
            {
                
                Console.WriteLine(item.Name);
            }


        }
    }
}