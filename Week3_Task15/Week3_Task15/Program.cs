using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week3_Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Information about drives on this PC");
            Console.WriteLine("");
            DriveInfo[] alldrives= DriveInfo.GetDrives();
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                try
                {
                    Console.WriteLine("Drive:{0}", d.Name);
                    Console.WriteLine("Drive Format:{0}", d.DriveFormat);
                    Console.WriteLine("Size:{0}", d.TotalSize);
                    Console.WriteLine("");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.ReadKey();
        }
    }
}
