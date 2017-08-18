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
                Console.WriteLine("ID потока {0}",Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                ThreadPool.QueueUserWorkItem(ShowInfo);
                Thread.Sleep(10);
            }
            
            Console.ReadKey();

        }
    }
}
