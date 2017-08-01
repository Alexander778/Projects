using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Activator_Case3
{
   public static class Universal_Constructor
    {
        
       public static  void Example(object obj)
        {
            object result;
            result = Activator.CreateInstance(Type.GetType(Convert.ToString (obj)));
            Console.WriteLine(result);
        }
    }
}

