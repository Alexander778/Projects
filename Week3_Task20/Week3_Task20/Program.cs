using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace Week3_Task20
{

    public class Win32
    {
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();
    }

    
    class Program
    {

        
        static void Main(string[] args)
        {
           
        
        
        Console.WriteLine("Computer Locker");
            Console.WriteLine("Do you want to lock your computer?Y/N");
            string decision = Console.ReadLine();
            switch(decision)
            {
                case "Y":
                    Win32.LockWorkStation();
                    break;
                case "N":
                    Environment.Exit(0);
                    break;

            }
            Console.ReadKey();
        }
    }
}
