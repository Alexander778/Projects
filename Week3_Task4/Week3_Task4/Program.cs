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
            
            int a = 0;
            int c = 0;
 
            int b = 0;
            int d = 0;

           
            

            ThreadPool.GetMaxThreads(out a, out b);
            ThreadPool.GetMinThreads(out c, out d);
            Console.WriteLine("Beniging MAX: {0},{1}", a, b);
            Console.WriteLine("Beniging MIN: {0},{1}", c, d);
            Console.WriteLine();

                ThreadPool.SetMaxThreads(30, 20);//before
                ThreadPool.SetMinThreads(15, 10);//before
                ThreadPool.GetMaxThreads(out a, out b);
                ThreadPool.GetMinThreads(out c, out d);

                Console.WriteLine("First change MAX: {0},{1}", a, b);
                Console.WriteLine("First change MIN: {0},{1}", c, d);
                Console.WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    ThreadPool.QueueUserWorkItem(GetList1);
                }

            WaitForThreads();
            //!Thread.Sleep(100);
                
             Console.WriteLine("_______________");

            ThreadPool.SetMaxThreads(20, 10); //after
            ThreadPool.SetMinThreads(10, 5);//after
            ThreadPool.GetMaxThreads(out a, out b);
            ThreadPool.GetMinThreads(out c, out d);
            Console.WriteLine("Second change MAX: {0},{1}", a, b);
            Console.WriteLine("Second change MIN: {0},{1}", c, d);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(GetList2);
            }
            Console.ReadKey();
            }

        public static void WaitForThreads()
        {
            int maxThreads = 0;
            int placeHolder = 0;
            int availThreads = 0;
            int timeOutSeconds = 5;

            
            while (timeOutSeconds > 0)
            {
                
                ThreadPool.GetMaxThreads(out maxThreads, out placeHolder);
                ThreadPool.GetAvailableThreads(out availThreads,out placeHolder);

                if (availThreads == maxThreads) break;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
               
            }
           
        }




    }
}
