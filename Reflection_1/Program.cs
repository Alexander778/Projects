/*using System;
using System.Reflection;
namespace Reflection_1
{
    class Methods
    {
       private static void Method1(string name)
        {
            Console.WriteLine("Hi! I'm Method1"+name);
        }

        private static void Method2<T>(T a)
		{

            Console.WriteLine("Обобщённый метод");

		}
    }
    class MainClass
    {
        public static void Main(string[] args)
        {

            Methods method1 = new Methods();
            MethodInfo mi = typeof(Methods).GetMethod("Method1",System.Reflection.BindingFlags.NonPublic| System.Reflection.BindingFlags.Instance);
            mi.Invoke(method1,);



        }
    }
}*/
using System;
using System.Reflection;

namespace FindPrivateMethod
{
	class Methods
	{
		private Methods()
		{
		}

		
        private void Method1(string name)
		{
			Console.WriteLine("Hello! My name is Method1" + name);
		}
		private static void Method2<T>(T a)
		{

			Console.WriteLine("Hello! I'm generic method!");

		}

		static void Main()
		{
			
            Methods t = new Methods();
            MethodInfo mi = typeof(Methods).GetMethod("Method1",System.Reflection.BindingFlags.NonPublic| System.Reflection.BindingFlags.Instance);
			mi.Invoke(t, new object[] { "I'm the best method!" });

			Methods t2 = new Methods();
			MethodInfo mi2 = typeof(Methods).GetMethod("Method2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
			mi.Invoke(t, new object[] { "I'm the best method too!" });
			Console.ReadKey();
		}
	}
}
