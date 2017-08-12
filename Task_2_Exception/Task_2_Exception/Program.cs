using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your nickname. Your nickname must have not more 10 symbols");
            try
            {
                string nick = Console.ReadLine();
                if (nick.Length > 10)
                {
                    throw new Exception("Lenght of your nickname is so long. Create new nickname!");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error:" + e.Message);
            }

            Console.ReadKey();
        }
    }
}
