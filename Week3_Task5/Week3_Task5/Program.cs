using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Week3_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alex", 20);
            Console.WriteLine("Object  is done for binary serialization ");

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person1);
                Console.WriteLine("Object is seriazibled by BinaryFormatter");
            }

            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Person newperson = (Person)formatter.Deserialize(fs);
                Console.WriteLine("Object is deserialized by BinaryFormatter");
                Console.WriteLine("Name: {0}  -------  Age:{1}", newperson.Name, newperson.Age);
            }
            Console.WriteLine("________________________");
            Console.WriteLine();

            //
            Person person2 = new Person("Anna", 4);
            Console.WriteLine("Object is done for soap serialization");
            SoapFormatter formatter1 = new SoapFormatter();

            using (FileStream fs = new FileStream("people.soap", FileMode.OpenOrCreate))
            {
                formatter1.Serialize(fs, person2);
                Console.WriteLine("Object is serialized by SoapFormatter");
            }

            using (FileStream fs = new FileStream("people.soap", FileMode.OpenOrCreate))
            {
                Person newperson1 = (Person)formatter1.Deserialize(fs);
                Console.WriteLine("Object is deserialized by SoapFormatter");
                Console.WriteLine("Name: {0}  -------  Age:{1}", newperson1.Name, newperson1.Age);

            }



                Console.ReadKey();
        }
    }
}
