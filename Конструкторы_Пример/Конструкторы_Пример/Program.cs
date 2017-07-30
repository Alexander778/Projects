using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конструкторы_Пример
{
    class Student
    {
        public string Name;
        public string SurName;
        public int Course;
        public int Stipendia;

        public Student(string Name, string SurName, int Course, int Stipendia)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Course = Course;
            this.Stipendia = Stipendia;
        }

       
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Alex", "Kuzmenko", 3, 1100);
            Student student2 = new Student("Anastasia", "Kuzenkova", 3, 1100);
            Console.WriteLine("Name: {0}\n Surname: {1}\n Course: {2}\n Stipendia: {3}\n", student1.Name, student1.SurName, student1.Course, student1.Stipendia);
            Console.WriteLine("Name: {0}\n Surname: {1}\n Course: {2}\n Stipendia: {3}\n", student2.Name, student2.SurName, student2.Course, student2.Stipendia);
            Console.ReadKey();
            

        }
    }
}
