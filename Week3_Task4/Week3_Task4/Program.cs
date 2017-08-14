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

                Console.WriteLine("Hello!");
            
        }
        static void Main(string[] args)
        {

            int Workers = 0;
            int AsyncIO = 0;
            ThreadPool.GetMaxThreads(out Workers,out AsyncIO);
            ThreadPool.GetMinThreads(out Workers, out AsyncIO);
            ThreadPool.SetMaxThreads(100, 100);
            ThreadPool.SetMinThreads(20, 20);
            ThreadPool.QueueUserWorkItem(GetList);
            
            Console.ReadKey();

             
        }
    }
}
