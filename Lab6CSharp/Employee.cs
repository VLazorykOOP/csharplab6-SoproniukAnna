using Lab6CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp
{
    internal class Employee : Person, ITask1
    {
        protected string Position { get; set; }
        protected int Salary { get; set; }

        public Employee()
        {
            this.Position = "Programmer";
            this.Salary = 1000;
            Console.WriteLine("Employee Default Constructor");
        }

        public Employee(string name, int age, string position, int salary) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Position = position;
            this.Salary = salary;
            Console.WriteLine("Employee Constructor with four param");
        }

        public Employee(string position, int salary)
        {
            this.Position = position;
            this.Salary = salary;
            Console.WriteLine("Employee Constructor with two param");
        }

        ~Employee()
        {
            Console.WriteLine("Employee Destructor");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {this.Position}, Salary: {this.Salary}");
        }
    }
}