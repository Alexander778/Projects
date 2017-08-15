using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Week3_Task4
{
    class Program
    {
        static void GetList(object arg)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("ID= {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(50);
            }
            
        }


        static void Main(string[] args)
        {

            int a, b;
            ThreadPool.GetMaxThreads(out a, out b);
            Console.WriteLine("Beniging: {0},{1}",a,b);
            Console.WriteLine();
            
            
            ThreadPool.SetMaxThreads(20,10);//before
            ThreadPool.SetMinThreads(8, 4);//before
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(GetList);
                Thread.Sleep(1000);
            }

            Console.WriteLine("_______________after");
            ThreadPool.SetMaxThreads(10, 5); //after
            ThreadPool.SetMinThreads(4,2);//after
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(GetList);
                Thread.Sleep(1000);
            }

            Console.ReadKey();

             
        }
    }
}
