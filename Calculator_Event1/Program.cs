using System;

namespace Calculator_Event
{
    public class Calculator
    {

        public delegate void History(double firstArg, double secondArg, string operation, double result);

        public event History OnHistory;

        public double Sum(double x, double y)
        {
            var result = x + y;
            if (OnHistory != null)
            {
                OnHistory(x, y, "+", result);
            }
            return result;
        }

        //1. остальные методы нужно переписать также как и Sum
          public double Raz (double x, double y)
           {
            var result = x - y;
               if(OnHistory !=null)
               {
                OnHistory(x, y, "-",result);
               }
               return result;

           }
           public double Umnog(double x, double y)
           {
            var result = x * y;
               if(OnHistory!=null)
               {
                OnHistory(x, y, "*",result);
               }
            return result;

           }
           public double Delen(double x,double y)
           {
            var result = x / y;
               if(OnHistory!=null)
               {
                   OnHistory(x, y, "/",result);
               }
               return result;

           }

        //!!!метод обработчик не может лежать в том же классе что и основной функционал
        //!!!в том то и суть обработчиков, мы можем подписаться на какое-то событие чужого класса
        //!!и выполнить свой код - переношу его в основную программу
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            //создаем экземпляр калькулятора, достаточно одного для тестирования всех операций
            Calculator myCalculator = new Calculator();



            //3. тут назначаем обработчик OnHistory который будет выводить историю
            //!!! Это должно быть обязательно, иначе события не будут обрабатываться, нету обработчика а мы проверяем его наличие в коде  if (OnHistory != null)
            myCalculator.OnHistory += HistoryMessage;



            myCalculator.Sum(15, 26);
            myCalculator.Delen(80, 5);
            myCalculator.Raz(78, 56);
            myCalculator.Umnog(2, 2);

            Console.ReadKey();
        }

        //метод-обработчик события
        public static void HistoryMessage(double x, double y, string operation, double result)
        {

            Console.WriteLine("{0}{1}{2}={3}", x, operation, y, result);
        }

    }

}
