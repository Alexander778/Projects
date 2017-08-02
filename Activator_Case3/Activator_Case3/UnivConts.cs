using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Activator_Case3
{
   public static class UnivConts
    {
        
       public static  object CreateInstanceOfClass(Type type)
        {
            
            Activator.CreateInstance(type);
            return type;
        }
    }
}

