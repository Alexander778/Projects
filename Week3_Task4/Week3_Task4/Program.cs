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
        static void GetList1(object arg)
        {
                Console.WriteLine("1 ID= {0}", Thread.CurrentThread.ManagedThreadId);
        }

		static void GetList2(object arg)
		{
			Console.WriteLine("2 ID= {0}", Thread.CurrentThread.ManagedThreadId);
		}


		static void Main(string[] args)
        {
            
            int a_MaxThreads = 0;
            int c_MinThreads = 0;
 
            int b_PlaceHolder = 0;
            int d_PlaceHolder = 0;

            int availThreads = 0;
            int timeOutSeconds = 5;

            ThreadPool.GetMaxThreads(out a_MaxThreads, out b_PlaceHolder);
            ThreadPool.GetMinThreads(out c_MinThreads, out d_PlaceHolder);
            Console.WriteLine("Beniging MAX: {0},{1}", a_MaxThreads, b_PlaceHolder);
            Console.WriteLine("Beniging MIN: {0},{1}", c_MinThreads, d_PlaceHolder);
            Console.WriteLine();
            while (timeOutSeconds > 0)
            {
                ThreadPool.SetMaxThreads(30, 20);//before
                ThreadPool.SetMinThreads(15, 10);//before
                ThreadPool.GetMaxThreads(out a_MaxThreads, out b_PlaceHolder);
                ThreadPool.GetMinThreads(out c_MinThreads, out d_PlaceHolder);
                ThreadPool.GetAvailableThreads(out availThreads, out b_PlaceHolder);
                Console.WriteLine("First change MAX: {0},{1}", a_MaxThreads, b_PlaceHolder);
                Console.WriteLine("First change MIN: {0},{1}", c_MinThreads, d_PlaceHolder);
                Console.WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    ThreadPool.QueueUserWorkItem(GetList1);
                }
                if (availThreads == a_MaxThreads) break;
            }
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                Console.WriteLine("_______________");

            ThreadPool.SetMaxThreads(20, 10); //after
            ThreadPool.SetMinThreads(10, 5);//after
            ThreadPool.GetMaxThreads(out a_MaxThreads, out b_PlaceHolder);
            ThreadPool.GetMinThreads(out c_MinThreads, out d_PlaceHolder);
            Console.WriteLine("Second change MAX: {0},{1}", a_MaxThreads, b_PlaceHolder);
            Console.WriteLine("Second change MIN: {0},{1}", c_MinThreads, d_PlaceHolder);
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(GetList2);
            }
            Console.ReadKey();
            }
            

            

             
        
    }
}
