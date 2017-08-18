using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Week3_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alex", 19);
            Console.WriteLine("Object is created");

            XmlSerializer formatter = new XmlSerializer(typeof(Person));

            using (FileStream fs = new FileStream("people.xml", FileMode.OpenOrCreate)) 
            {
                formatter.Serialize(fs, person1);
                Console.WriteLine("Object is serialized");
            }

            using (FileStream fs = new FileStream("people.xml", FileMode.OpenOrCreate)) 
            {
                Person newperson1 = (Person)formatter.Deserialize(fs);
                Console.WriteLine("Object is deserialized");
                Console.WriteLine("Name: {0} Surname: {1}",newperson1.Name,newperson1.Age);
            }
            Console.ReadKey();
            


        }
    }
}
