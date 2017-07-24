using System;

namespace Calculator_Event
{
    public class Calculator
    {

        //расширил делегат, добавил необходимые параметры
        public delegate void History(double firstArg, double secondArg, string operation, double result);

        //зачем это было закомментировано? - раскомментировал, нам же нужно где-то хранить обработчик события
        public event History OnHistory;


        //зачем тут ref? он тут не нужен - убрал во всех операциях
        //public void Sum(ref double x, ref double y)
        public double Sum(double x, double y)
        {
            //везде повставлял вызовы обработчика, не забываем проверять на null
            //ведь обработчик могут и не назначить и тогда будет ошибка
            var result = x + y;
            if (OnHistory != null)
            {
                OnHistory(x, y, "+", result);
            }
            //логично что метод суммирования должен возвращать результат этого самого суммирования а не void
            return result;
        }

        //1. остальные методы нужно переписать также как и Sum
     /*   public double Raz (double x, double y)
        {
            if(OnHistory !=null)
            {
                OnHistory(x, y, "-");
            }
            return x - y;

        }
        public double Umnog(double x, double y)
        {
            if(OnHistory!=null)
            {
                OnHistory(x, y, "*");
            }
            return x * y;

        }
        public double Delen(double x,double y)
        {
            if(OnHistory!=null)
            {
                OnHistory(x, y, "/");
            }
            return x / y;

        }*/

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

            //Изменения тут 
            // Это неверно - комментирую
            /*myCalculator.HistoryMessage(15, 26, "+",myCalculator.Sum(15,26));
            myCalculator.HistoryMessage(78, 56, "-", myCalculator.Raz(78, 56));
            myCalculator.HistoryMessage(2, 2, "*", myCalculator.Umnog(2, 2));
            myCalculator.HistoryMessage(80, 5, "/", myCalculator.Delen(80, 5));*/
            //

            //3. тут назначаем обработчик OnHistory который будет выводить историю
            myCalculator.OnHistory += HistoryMessage;


            //Я убрал эти методы, так как они считают цифры непосредственно в вызове события.Можно так делать? 
            //зря убрал
            myCalculator.Sum(15, 26);
         /*   myCalculator.Delen(80, 5);
            myCalculator.Raz(78, 56);
            myCalculator.Umnog(2, 2);*/


            Console.ReadKey();
        }

        //метод-обработчик события
        public static void HistoryMessage(double x, double y, string operation, double result)
        {

            Console.WriteLine("{0}{1}{2}={3}", x, operation, y, result);
        }

    }
        


    }
