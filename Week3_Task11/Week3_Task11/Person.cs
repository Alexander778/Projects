using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3_Task11;

namespace Week3_Task11
{
    class Person:IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Done");
        }
    }
}
