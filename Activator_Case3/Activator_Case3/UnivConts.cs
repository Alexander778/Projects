using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Activator_Case3;

namespace Activator_Case3
{
   public static class UnivConts
    {
        
       public static object CreateInstanceOfClass(Type t)
        {
            object instance = Activator.CreateInstance(t);
            Console.WriteLine(instance);
            return t;
            
            
        }
    }
}

