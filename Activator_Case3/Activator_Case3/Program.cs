using System;
using Activator_Case3;
namespace Reflection1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnivConts.CreateInstanceOfClass(typeof(Example));
            //object obj;
            //obj = Example.Print(6);
            Console.ReadKey();
        }
    }
}