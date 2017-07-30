using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cтатические_и_простые_методы___разница
{
    class Program
    {
        class SimpleMethod
        {
            public int Suma(int a,int b) //Простой метод.Вызывается созданием экземпляра класса и непосредсвенно названием самого метода
            {
                int result;
                result = a + b;
                return result;
            }
        }

        class StaticMethod
        {
            public static int Multiply(int x, int y) //Cтатический метод. Вызывается без создания экземпляра класса
            {
                int result;
                result = x * y;
                return result;
            }
        }
        // Статические методы, обычно, выполняют какую-нибудь глобальную, общую функцию, обрабатывают «внешние данные». 
        //Например, сортировка массива, обработка строки, возведение числа в степень и другое.
        static void Main(string[] args)
        {
            //Простой
            SimpleMethod sm1 = new SimpleMethod();
            SimpleMethod sm2 = new SimpleMethod();
            int a = sm1.Suma(2, 3);
            int b = sm2.Suma(45, 67);
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Статический
            int c = StaticMethod.Multiply(34, 45);
            int d = StaticMethod.Multiply(100, 34);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
