using System;
using System.Reflection;
namespace Reflection_2
{
    class A
    {
        private A(){}
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
			Type t = typeof(A);
			A obj = (A)t.GetConstructors()[0].Invoke(null);



		}
    }
}
