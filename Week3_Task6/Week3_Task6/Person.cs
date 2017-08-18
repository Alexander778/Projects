using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace Week3_Task6
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        [NonSerialized]
        public string SurName;
        public Person(string name, int age,string surname)
        {
            Name = name;
            Age = age;
            SurName = surname;
        }
        
    }

}