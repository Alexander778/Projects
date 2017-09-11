using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифр_Цезаря
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Что будем делать? Шифровать - c,дешифровать - d ");
            string desicion = Console.ReadLine();
            switch(desicion)
            {
                case "c":
                    Coding();
                    break;
                case "d":
                    DeCoding();
                    break;

                    


            }
            Console.ReadKey();

        }

        static void Coding()
        {
            Console.WriteLine("Введите слово, которое нужно зашифровать");
            string s = Console.ReadLine();
            Console.WriteLine("Укажите ключ");
            int key = Convert.ToInt32(Console.ReadLine());


            string alf = "abcdefghijklmnopqrstuvwxyz";
            string code = "";
            int m = alf.Length;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < alf.Length; j++)
                {
                    if (s[i] == alf[j])
                    {
                        int temp = j + key;

                        while (temp >= m)
                            temp = temp - m;
                        code = code + alf[temp];
                    }
                }

            }

            Console.WriteLine(code);
        }
        static void DeCoding()
        {
            Console.WriteLine("Введите слово, которое нужно дезашифровать");
            string s = Console.ReadLine();
            Console.WriteLine("Укажите ключ");
            int key = Convert.ToInt32(Console.ReadLine());
            
            string alf = "abcdefghijklmnopqrstuvwxyz";
            string decode = "";
            int m = alf.Length;
            
            
                for (int i = 0; i < s.Length; i++)
                {

                    for (int j = 0; j < alf.Length; j++)
                    {

                        if (alf[j] == s[i])
                        {
                            int temp = j - key;
                            while (temp < 0)
                                temp = temp + m;
                            while (temp >= m)
                                temp = temp - m;

                            decode = decode + alf[temp];
                        }

                    }

                
                
            }
            Console.WriteLine("");
            Console.WriteLine(decode);
        }
    }
}
