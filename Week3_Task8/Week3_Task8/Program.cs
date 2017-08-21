using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace Week3_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Persons.dat";
            IFormatter formatter = new BinaryFormatter();

            Program.SerialzeItem(fileName, formatter);
            Program.DeserializeItem(fileName,formatter);

            Console.WriteLine("Done");
            Console.ReadKey();

            
        }

        public static void SerialzeItem(string fileName, IFormatter formatter)
        {
            Person p1 = new Person();
            p1.Name = "Alex";

            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, p1);
            s.Close();
        }

        public static void DeserializeItem(string fileName, IFormatter formatter)
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            Person p1 = (Person)formatter.Deserialize(s);
            Console.WriteLine(p1.Name);
        }

    }
}
