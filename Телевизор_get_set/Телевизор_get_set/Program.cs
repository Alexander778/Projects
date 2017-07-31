using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Телевизор_get_set
{
    //Создайте класс Телевизор, объявите в нем поле громкость звука, для доступа к этому полю реализуйте свойство. 
    //Громкость может быть в диапазоне от 0 до 100.
    // Зачем это нужно?Если, например, мы бы просто сделали поле year открытым и не использовали ни методы, ни свойство для доступа, мы могли бы записать в это поле любое значение, в том числе и некорректное, а так мы можем контролировать чтение и запись.
    class Program
    {
        class TVVolume
        {
            private int volume;
            public int Volume
            {
                get
                {
                    return volume;
                }
                set
                {
                    if (volume > 0 || volume <100)
                        volume = value;
                    else if (volume < 0 || volume > 100)
                        Console.WriteLine("Error");
                    
                }
            }
        }

        static void Main(string[] args)
        {
            TVVolume vol1 = new TVVolume();
            vol1.Volume = 67;
            Console.WriteLine(vol1.Volume);
            Console.ReadKey();
        }
    }
}
