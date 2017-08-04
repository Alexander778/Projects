using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activator_Case3;

namespace Activator_Case3
{
    class PrivateClass
    {
        public int A { get; set; }
        public int B { get; set; }
        private PrivateClass(int a,int b)
            {
            this.A = a;
            this.B = b;
            }
        public int ShowResult(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }
    }

}
