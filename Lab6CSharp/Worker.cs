using Lab6CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp
{
    internal class Worker : Employee, ITask1
    {
        protected string Department { get; set; }

        public Worker()
        {
            this.Department = "ggg";
            Console.WriteLine("Worker Default Constructor");
        }

        public Worker(string name, int age, string position, int salary, string department) : base(name, age, position, salary)
        {
            this.Name = name;
            this.Age = age;
            this.Position = position;
            this.Salary = salary;
            this.Department = department;
            Console.WriteLine("Worker Constructor with five param");
        }

        public Worker(string department)
        {
            this.Department = department;
            Console.WriteLine("Worker Constructor with one param");
        }

        ~Worker()
        {
            Console.WriteLine("Worker Destructor");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Department: {this.Department}");
        }
    }
}