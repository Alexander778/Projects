using System;
using Activator_Case3;
namespace Reflection1
{
    class Program
    {
        static void Main(string[] args)
        {
            //UnivConts.CreateInstanceOfClass(typeof(Example));
            object o1 = UnivConts.CreateInstanceOfClass(typeof(SimpleExample));
            var result = ((SimpleExample)o1).Show(10);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}