using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Week3_Task_3
{
    class Program
    {
        static void ShowInfo(object arg)
        {
            int counter = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Цифра {0}, id потока {1}", i, Thread.CurrentThread.ManagedThreadId);
                //
                int id = Thread.CurrentThread.ManagedThreadId;
                List<int> IDs = new List<int>();
                IDs.Add(id);
                int count = IDs.Count;
                //
                Thread.Sleep(10);
                counter = count;
            }

            Console.WriteLine("Статистика:");
            Console.WriteLine("Поток, который используется: {0}",Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Количество используемых потоков:"+counter);
            
        }
        static void Main(string[] args)
        {
            
            ThreadPool.QueueUserWorkItem(ShowInfo);
            Thread.Sleep(3000);
            Console.WriteLine();
            

            Console.ReadKey();

        }
    }
}
