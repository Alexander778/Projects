using System;

namespace Calculator_Event
{
    public class Calculator
    {

        //расширил делегат, добавил необходимые параметры
        public delegate void History(double firstArg, double secondArg, string operation);

        //зачем это было закомментировано? - раскомментировал, нам же нужно где-то хранить обработчик события
        public event History OnHistory;


        //зачем тут ref? он тут не нужен - убрал во всех операциях
        //public void Sum(ref double x, ref double y)
        public double Sum(double x, double y)
        {
            //везде повставлял вызовы обработчика, не забываем проверять на null
            //ведь обработчик могут и не назначить и тогда будет ошибка
            if (OnHistory != null)
            {
                OnHistory(x, y, "+");
            }
            //логично что метод суммирования должен возвращать результат этого самого суммирования а не void
            return x + y;
        }

        //1. остальные методы нужно переписать также как и Sum
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

    class MainClass
    {
        public static void Main(string[] args)
        {
            //создаем экземпляр калькулятора, достаточно одного для тестирования всех операций
            Calculator myCalculator = new Calculator();

            //3. тут назначаем обработчик OnHistory который будет выводить историю


            //считаем на калькуляторе
            myCalculator.Sum(15, 26);
            myCalculator.Delen(80, 5);
            myCalculator.Raz(78, 56);
            myCalculator.Umnog(2, 2);


            Console.ReadKey();
        }


        //2. тут определяем метод-обработчик события можно прямо в этом же классе 


    }
}