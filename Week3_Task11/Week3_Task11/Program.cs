using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Task11
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Test();
            Console.ReadKey();
        }

        private static void Test()
        {
            Person p = null;
            try
            {
                p = new Person();
            }
            finally
            {
                if (p != null)
                {
                    p.Dispose();
                }
            }
        }


    }
}
