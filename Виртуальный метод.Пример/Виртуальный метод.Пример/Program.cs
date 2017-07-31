using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Виртуальный_метод.Пример
{
    /*Создайте три класса: Воин, Воин_в_легких_доспехах и Воин_в_тяжелых_доспехах. 
     * У всех них есть свойство – Количество_жизней, а также метод Получить_урон, который принимает в качестве аргумента значение получаемого урона. 
     * Реализуйте этот метод по-разному для всех типов, установив различные коэффициенты в зависимости от типа доспехов в формуле вычета здоровья.*/
    class Program
    {

        class Warrior
        {
            public int HP { get; set; }
            public Warrior(int HP) //конструктор
            {
                this.HP = HP;
            }

            public virtual void Damage() //виртуальный метод: который потом переопределим в классе-наследнике
            {
                int result = HP - 100;
                if (result > 0)
                {
                    Console.WriteLine("Damage is done. This Warrior has {0} hp", result);
                }
                else if (result == 0 || result <0)
                {
                    Console.WriteLine("Damage is done. This Warrior is dead. Sorry");
                }
               
            }
        }

        class LightWarrior:Warrior
        {
            public int Armor { get; set; }//у каждого воина есть броня, кроме первого(класса-родителя)
           
            public LightWarrior(int hp, int armor) : base(hp)//наследуем конструктор от класса Воин
            {
                this.Armor = armor;
            }

            public override void Damage() // переопределяем метод с помощью ключевого слова override
            {
                int result = HP - 400+Armor;
                if (result > 0)
                {
                    Console.WriteLine("Damage is done. This LightWarrior has {0} hp", result);
                }
                else if (result == 0 || result < 0)
                {
                    Console.WriteLine("Damage is done. This LightWarrior is dead. Sorry");
                }

            }
        }

        class HeavyWarrior:Warrior
        {
            public int Armor { get; set; }// броня
            public HeavyWarrior(int hp, int armor) : base(hp) //наследуем конструктор от класса Воин
            {
                this.Armor = armor;
            }

            public override void Damage() // переопределяем метод с помощью ключевого слова override
            {
                int result = HP - 2000 + Armor;
                if (result > 0)
                {
                    Console.WriteLine("Damage is done. This HeavyWarrior has {0} hp", result);
                }
                else if (result == 0 || result < 0)
                {
                    Console.WriteLine("Damage is done. This HeavyWarrior is dead. Sorry");
                }

            }
        }
        static void Main(string[] args)
        {
            Warrior war1 = new Warrior(90); //создаём первого воина без брони, и задаём здоровье
            LightWarrior lwar1 = new LightWarrior(3000, 10); // создаём второго воина уже с легкой бронёй
            HeavyWarrior hwar1 = new HeavyWarrior(1000, 100);//создаём 3-го воина уже в тяжелой броне
            war1.Damage();//
            lwar1.Damage();// вызываем методы:которые на все методы:которые нам всё посчитают и выведут результат в консоль
            hwar1.Damage();//
            Console.ReadLine();
        }
    }
}
