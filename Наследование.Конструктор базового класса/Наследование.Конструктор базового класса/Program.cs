using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование.Конструктор_базового_класса
{
    class Program
    {
        /*Создайте базовый класс Геометрическая фигура, предусмотрите в нем общие поля/свойства, например координаты центра фигуры, с помощью конструктора должна быть возможность задать центр. 
         * На базе этого класса создайте два новых – Треугольник(у меня квадрат!) и Окружность. 
         * В этих классах должны быть свои особые поля, например радиус для окружности. 
         * В оба класса добавьте метод Нарисовать, в котором могла бы быть специфическая логика рисования фигуры. 
         * Создайте объекты треугольник и окружность.*/

        class Shape
        {
            public int x_center;
            public int y_center;

            public Shape(int x, int y) //конструктор
            {
                this.x_center = x;
                this.y_center = y;
            }
        }


        class Square : Shape
        {
            public int Diagonal { get; set; }

            public Square(int x, int y, int diagonal) : base(x, y) //конструктор точнее наследования конструктора и его параметров икм и игрек
            {
                Diagonal = diagonal;
            }
            public void Paint2()
            {
                Console.WriteLine("Square\nCenter({0};{1})\nDiagonal:{2}",x_center,y_center,Diagonal);
            }

        }

        class Circle:Shape
        {
            public int Radius { get; set; }
            public Circle(int x,int y,int radius) : base(x,y) //конструктор точнее наследования конструктора и его параметров икм и игрек
            {
                Radius = radius;
            }

           public void Paint() //метод якобы рисования фигуры, но у меня просто выводит информацию о фигуре
            {
                Console.WriteLine("Circle\nCenter({0};{1})\nRadius:{2}",x_center,y_center,Radius);
            }
        }
        static void Main(string[] args)
        {
            Square sq = new Square(2,3,10);
            Circle ci = new Circle(3, 4, 4);
            ci.Paint();
            sq.Paint2();
           

            Console.ReadKey();
        }
    }
}
