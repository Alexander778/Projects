using System;

namespace Calculator_Event
{


    public class Calculator
    {

        public delegate void History();
        //public event History OnHistory;



        public void Sum(ref double x, ref double y)
        {

            double result = x + y;
            //OnHistory();
            Console.WriteLine("History of operations");
            Console.WriteLine("{0}+{1}={2}",x,y,result);

        }
        public void Raz(ref double a, ref double b)
        {
            double result = a - b;
            //OnHistory();
           Console.WriteLine("{0}+{1}={2}", a, b, result);

        }
        public void Umnog(ref double c, ref double d)
        {
            double result = c * d;
            //OnHistory();
            Console.WriteLine("{0}+{1}={2}", c, d, result);

        }
        public void Delen(ref double q, ref double w)
        {
            double result = q / w;
           //OnHistory();
          Console.WriteLine("{0}+{1}={2}", q, w, result);

        }

    }

   /* class Handler_I
    {
        public void Message()
        {
            
			Console.WriteLine("История вычислений:");
            Console.WriteLine();
            Console.WriteLine("Пример суммы");
			Console.WriteLine("Пример разницы");
			Console.WriteLine("Пример умножения");
			Console.WriteLine("Пример деления");


        }*/
   // }
    /* class Handler_II
    {
        public void Message()
        {
            Console.WriteLine("{0}-{2}");

        }
    }
    class Handler_III
    {
        public void Message()
        {
            Console.WriteLine("{0}*{3}");

        }
    }
    class Handler_IV
    {
        public void Message()
        {
            Console.WriteLine("{0}/{4}");

        }
    }
    */
    class MainClass
    {
        public static void Main(string[] args)
        {
            //cчитаем сумму x y
            Console.WriteLine("Let's count the sum");
            Console.WriteLine("Enter first number:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double y = Convert.ToDouble(Console.ReadLine());
            Calculator Suma = new Calculator();
            //Suma.Sum(ref x, ref y);


			//считаем разницу a b
			Console.WriteLine("Let's count the diffrence");
			Console.WriteLine("Enter first number:");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter second number:");
			double b = Convert.ToDouble(Console.ReadLine());
			Calculator Diff = new Calculator();
            //Diff.Raz(ref a, ref b);

			//считаем умножение c d
			Console.WriteLine("Let's count the multiply");
			Console.WriteLine("Enter first number:");
			double c = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter second number:");
			double d = Convert.ToDouble(Console.ReadLine());
			Calculator Mul = new Calculator();
			//Mul.Umnog(ref c, ref d);

			//считаем деление q w
			Console.WriteLine("Let's count the division");
			Console.WriteLine("Enter first number:");
			double q = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter second number:");
			double w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
			Calculator Div = new Calculator();
			//Div.Delen(ref q, ref w);

			/*Handler_I Handler1 = new Handler_I();
            Suma.OnHistory += Handler1.Message;
            Diff.OnHistory += Handler1.Message;
            Mul.OnHistory += Handler1.Message;
            Div.OnHistory += Handler1.Message;*/

            Suma.Sum(ref x, ref y);
            Diff.Raz(ref a, ref b);
            Mul.Umnog(ref c, ref d);
            Div.Delen(ref q, ref w);


        }














    }
}


    

