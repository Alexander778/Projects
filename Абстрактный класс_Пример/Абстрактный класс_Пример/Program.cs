using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактный_класс_Пример
{
    /*Создайте абстрактный класс Человек, пусть там будет свойство Имя и абстрактный метод СказатьПриветствие(), от этого класса будет несколько наследников, которые представляют национальность (русский, украинец, американец...). 
     * Должно получиться так, что при вызове метода СказатьПриветствие() выводилось приветствие на языке соответствующему национальности (Привет, Привіт, Hi...).*/

    /*Абстрактный метод – это метод, который не имеет своей реализации в базовом классе, и он ДОЛЖЕН быть реализован в классе-наследнике. 
     * Абстрактный метод может быть объявлен только в абстрактном классе.
    Какая же разница между виртуальным и абстрактным методом?
-	Виртуальный метод может иметь свою реализацию в базовом классе, абстрактный – нет (тело пустое);
-	Абстрактный метод должен быть реализован в классе наследнике, виртуальный метод переопределять необязательно.*/
    abstract class Human // Создаём абстрактный класс Человек
    {
        public string Name { get; set; } // Создаём там одно свойство 
        public Human(string name) // Делаем конструктор
            {
            Name = name;
            }
        public abstract void SayHi(); //  Прописываем абстрактный метод, который ничего не возвращает
    }
    class Ukrainian : Human // Создаём класс-наследник
    {
        public Ukrainian(string name):base(name) //наследуем конструктор базового класса
        {
            Name = name;
        }
        public override void SayHi()// переназначаем абстрактный метод
        {
            Console.WriteLine("{0} говорит Доброго дня!",Name);
        }
    }

    class English : Human // Создаём класс-наследник
    {
        public English(string name) : base(name)
        {
            Name = name;
        }
        public override void SayHi()
        {
            Console.WriteLine("{0} говорит Hi!", Name);
        }
    }
       class Russian : Human // Создаём класс-наследник
    {
            public Russian(string name):base(name)
            {
                Name = name;
            }
            public override void SayHi()
            {
                Console.WriteLine("{0} говорит Привет!",Name);
            }
        }


    
    class Program
    { 
        static void Main(string[] args)
        {

            Ukrainian Petro = new Ukrainian("Petro");
            English John = new English("John");// Создаём как бы экземпляры классов-наследников
            Russian Ivan = new Russian("Ivan");
            Petro.SayHi();
            John.SayHi();//вызываем методы
            Ivan.SayHi();
            
            Console.ReadKey();
        }
    }
}

