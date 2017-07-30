using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    class Televison
    {
        public int ChannelNow = 1;
        public void ChangeChannelByNumber(int ChannelNow) //
        {
            
            Console.WriteLine("Now you on {0} channel", ChannelNow);
        }
        
        public void ChangeChannelUp() //
        {
            if (ChannelNow < 100)
            {
                ChannelNow = ChannelNow + 1;
                Console.WriteLine("Now you are on {0} channel", ChannelNow);
            }
            else if (ChannelNow == 100)
            {
                ChannelNow = 1;
                Console.WriteLine("Now you are on {0} channel", ChannelNow);
            }

        }
        public void ChangeChannelBack() //
        {
            if (ChannelNow > 0 && ChannelNow != 1)
            {
                ChannelNow = ChannelNow - 1;
                Console.WriteLine("Now you are on {0} channel", ChannelNow);
            }
            else if (ChannelNow == 1)
            {
                ChannelNow = 100;
                Console.WriteLine("Now you are on {0} channel", ChannelNow);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TELEVISON. WE HAVE ONLY 100 CHANNELS");
            Console.WriteLine("NOW YOU ARE ON 1 CHANNEL");
            Televison tv1 = new Televison();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Change channel: up,back or enter your number");
                string action;
                action = Console.ReadLine();
                if (action == "up")
                {
                    tv1.ChangeChannelUp();
                }
                else if (action == "back")
                {
                    tv1.ChangeChannelBack();
                }
                else if (action != "up" && action != "back")
                {
                    tv1.ChangeChannelByNumber(Convert.ToInt32(action));
                    tv1.ChannelNow = Convert.ToInt32(action); 
                }
            }


            Console.ReadKey();
        }
        


    }
}
    

