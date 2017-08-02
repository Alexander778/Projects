using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activator_Case3;

namespace Activator_Case3
{
    class Program
    {
        static void Main(string[] args)
        {
            Type p = typeof(UInt32);
            UnivConts.CreateInstanceOfClass(p);
            Console.WriteLine(p);
            
            
            Console.ReadKey();
            
        }
    }
}
