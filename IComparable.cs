using System;

namespace Сomparable
{
	
    class Employee: IComparable
    {
        public string name { get; set; }
        public int id { get; set; }

        public int CompareTo(object obj)
        {
            Employee emp = obj as Employee;
            if(emp !=null)
            {
                return this.name.CompareTo(emp.name);
            }
            else
            {
                throw new NullReferenceException("Error");
            }

        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee[] emps = new Employee[5];
            emps[0] = new Employee() { name = "Alex", id = 4 };
            emps[1] = new Employee() { name = "Shura", id = 28 };
            emps[2] = new Employee() { name = "Petya", id = 40 };
            emps[3] = new Employee() { name = "Artem", id = 21 };
            emps[4] = new Employee() { name = "John", id = 56 };


            Array.Sort(emps);

            foreach(Employee emp in emps)
            {
                Console.WriteLine(emp.name);
            }
        }
    }
}
