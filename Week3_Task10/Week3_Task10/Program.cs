using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Week3_Task10
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Human h1 = new Human("Alex");
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Alexander\Desktop\human.data", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, h1);
            Console.WriteLine("Done");
            stream.Close();
            stream = new FileStream(@"C:\Users\Alexander\Desktop\human.data", FileMode.Open, FileAccess.Read);
            Human newhuman = (Human)formatter.Deserialize(stream);
            Console.WriteLine("Object is deserialized");
            Console.WriteLine("Name: {0}",newhuman.Name);


            Console.ReadKey();
                      
        }
    }
}
