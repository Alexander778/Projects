using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activator_Case3;

namespace Activator_Case3
{
    public class PrivateClass
    {
        public int A { get; set; }
        public int B { get; set; }
        private PrivateClass()
            {
            
            }
        public int ShowResult(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }
    }

}
