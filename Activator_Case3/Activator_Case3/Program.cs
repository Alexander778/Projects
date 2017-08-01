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
            Class1 cl1 = new Class1();
            Universal_Constructor.Example(cl1);
            
            
            Console.ReadKey();
            
        }
    }
}
