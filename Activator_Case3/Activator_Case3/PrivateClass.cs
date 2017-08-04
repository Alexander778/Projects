using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activator_Case3
{
    class PrivateClass
    {
        private int A { get; set; }
        private int B { get; set; }
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
