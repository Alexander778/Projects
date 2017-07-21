using System;

namespace Calculator_Event
{
    public class Calculator
    {
        public delegate void History();

        public event History OnHistory;

        public  void Sum()
        {
            int x = 10;
            int y = 20;
            int result = x + y;
            OnHistory();

        }
    }

    class Handler_I
    {
        public void Message()
        {
            Console.WriteLine("10+20=30");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator Suma = new Calculator();
            Handler_I Handler1 = new Handler_I();
            Suma.OnHistory += Handler1.Message;


            //вот оно
            Suma.Sum();
            Console.ReadKey();
          

        }
    }
}
