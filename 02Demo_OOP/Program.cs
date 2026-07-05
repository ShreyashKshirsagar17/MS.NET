namespace _02Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("By using ChildClass Object Parameterized constructor");
            Devloper Dv =new Devloper("Shreyash","IT");

            Console.WriteLine("By using ChildClass Object");
            Devloper devloper = new Devloper();

            Console.WriteLine("By using Base_Class Object");
            Employee Employee = new Employee();

            Console.WriteLine("By using ChildClass Object Parameterized constructor");
            Employee employee1 = new Employee("HR");

        }
    }

    class Employee
    {
        public string Department;
        public Employee()
        {
            Console.WriteLine("Employee class Default constructor");
        }

        public Employee(string dept)
        {
            Department=dept ;
            Console.WriteLine($"Employee class Parameterized constructor {Department}");
        }
    }

    class Devloper : Employee
    {
        public string Name;

        public Devloper():base()
        {
            Console.WriteLine("Devloper class Default constructor");

        }
        public Devloper(string name, string dept) : base(dept)
        {
            Name = name;
            Console.WriteLine($"Devloper class Parameterized constructor {Name}");
        }   
    }
}
