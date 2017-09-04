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
            Console.WriteLine("Enter any button");
            
            for (int i = 0; i < 10; i++)
            {
                var a = Console.ReadKey();
                if ( a!= null)
                {
                    Console.Beep();
                }
                else
                {

                }
            }
            Console.ReadKey();
            
        }
    }
}
