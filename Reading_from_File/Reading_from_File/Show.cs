using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reading_from_File;

namespace Reading_from_File
{
    class Show
    {
        public static void ShowText()
        {
            string file;
            //Console.WriteLine("Введите путь к файлу");
            file = (@"C:\Users\Alexander\Desktop\ex.txt");
            string text = System.IO.File.ReadAllText(file);

            string[] fileF = text.Split(new Char[] { ' ' });

            foreach (string s in fileF)
            {
                
                Console.WriteLine(s);
                
            }
            


            //Console.WriteLine(text);
            //Console.WriteLine(file.Length);
            Console.ReadKey();


        }
    }
}
