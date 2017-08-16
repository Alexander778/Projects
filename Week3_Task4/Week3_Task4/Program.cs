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
                Console.WriteLine("ID= {0}", Thread.CurrentThread.ManagedThreadId);
        }


        static void Main(string[] args)
        {
            //
            int a, b, c, d;
            ThreadPool.GetMaxThreads(out a, out b);
            ThreadPool.GetMinThreads(out c, out d);
            Console.WriteLine("Beniging MAX: {0},{1}",a,b);
            Console.WriteLine("Beniging MIN: {0},{1}", c, d);
            Console.WriteLine();
            //

            //
            
            ThreadPool.SetMaxThreads(30,20);//before
            ThreadPool.SetMinThreads(15, 10);//before
            ThreadPool.GetMaxThreads(out a, out b);
            ThreadPool.GetMinThreads(out c, out d);
            Console.WriteLine("First change MAX: {0},{1}",a,b);
            Console.WriteLine("First change MIN: {0},{1}", c, d);
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(GetList);
                Thread.Sleep(10);
            }
            
            //

            //
            Console.WriteLine("_______________");
            //

            //
            ThreadPool.SetMaxThreads(20, 10); //after
            ThreadPool.SetMinThreads(10,5);//after
            ThreadPool.GetMaxThreads(out a, out b);
            ThreadPool.GetMinThreads(out c, out d);
            Console.WriteLine("Second change MAX: {0},{1}", a, b);
            Console.WriteLine("Second change MIN: {0},{1}", c, d);
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(GetList);
                Thread.Sleep(10);
            }
            //
            
            Console.ReadKey();

             
        }
    }
}
