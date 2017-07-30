using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activator_3_Case
{

    public class Example
    {
        public void DoSmth(int x)
        {
            Console.WriteLine("Result: 100 / {0} = {1}",x,100/x);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Object o = Activator.CreateInstance(typeof(StringBuilder));
            StringBuilder sb = (StringBuilder)o;
            sb.Append("Hello, world!");
            Example ds = new Example();
            ds.DoSmth(5);
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
