using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Week3_Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter any button");
                ConsoleKeyInfo x = Console.ReadKey();
                if (x.KeyChar != 13)//код Enter
                {
                    Console.WriteLine("");
                    char y = x.KeyChar;
                    int freq = y * 3;//для наглядности увеличиваю параметры частоты и длительности
                    int dur = y * 10;
                    Console.Beep(freq, dur);
                }
                else
                {
                    Environment.Exit(0);
                }
                
            }
        }
        }
    }

