using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифр_Цезаря
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 1;
            Console.WriteLine("Введите слово, которое нужно зашифровать"); 
            string s = Console.ReadLine(); //читаем то что ввели
            Console.WriteLine("Укажите ключ");
            int key = Convert.ToInt32(Console.ReadLine());//читаем ключ переводя его в нужный формат, то есть строка что ввели перевелась в цифру
          

            string alf = "abcdefghijklmnopqrstuvwxyz"; //массив букс
            string code = "";//будущая строка вывода шифротекста, которая сейчас пустая
            int m = alf.Length; //это переменная которая указывает длинну массива(количество букв в алфавите)
            for (int i = 0; i < s.Length; i++)//цикл который перебирает все буквы слова что было введенно s.Lenght - это количество букв в слове что ввели
            {
                for (int j = 0; j < alf.Length; j++)//перебираем алфавит 
                {
                    if (s[i] == alf[j])//если у нас буква с тогочто мы ввели совпала с буквой с алфавита
                    {
                        int temp = j  + key;//то мы добавляем смещение

                        while (temp >= m)// тут мы исключаем тот случай когда ключ будет большим и алфавит сместиться с конца в начало
                            temp =temp - m;//тут мы добиваем тот самый индекс когда ключ слишком большой, то есть больше чем количество букв в алфавите
                        code = code + alf[temp];//заполняем наш шифротекст
                    }
                }
                
            }
           
            Console.WriteLine(code);//выводим на экран
            Console.ReadKey();

        }

        
    }
}
