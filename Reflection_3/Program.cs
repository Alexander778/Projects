using System;
using System.Reflection;
namespace Reflection_3
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Field)]
    public class MySpecialAttribute : Attribute
    {
        public string Example;
        public MySpecialAttribute() { }
        public MySpecialAttribute(string Exam)
        {
            Example = Exam;
        }
    }

    class MainClass
    {
        [MySpecial(Example = "Главный метод программы")]
        public static void Main(string[] args)
        {
            Type t = typeof(MySpecialAttribute);
            object[] obj = t.GetCustomAttributes(false);
            foreach (object o in obj)
                Console.WriteLine(o);

                       Console.ReadKey();

           
        }
    }
}
    

