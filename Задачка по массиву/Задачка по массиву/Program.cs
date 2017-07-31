using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачка_по_массиву
{
    class Program
    {//Дано два массива одинаковой длины (по 10 элементов). 
     //Создайте третий массив, который будет отображать сумму первых двух массивов. 
     //Первый элемент третьего массива равен сумме первых элементов двух первых массивов и так далее.
        static void Main(string[] args)
        {
            int[] mas1 = new int[11];
            int[] mas2 = new int[11];
            int[] mas3 = new int[11];
            for (int i = 1; i < 11; i++)
            {
                mas1[i] = i;
                mas2[i] = i + 10;
                mas3[i] = mas1[i] + mas2[i];
                Console.WriteLine(mas3[i]);
            }
            Console.ReadLine();
        }
    }
}
