using Lab6CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp
{
    internal class Engineer : Worker, ITask1
    {
        protected string Specialization { get; set; }

        public Engineer()
        {
            this.Specialization = "aaa";
            Console.WriteLine("Engineer Default Constructor");
        }

        public Engineer(string name, int age, string position, int salary, string department, string specialization) : base(name, age, position, salary, department)
        {
            this.Name = name;
            this.Age = age;
            this.Position = position;
            this.Salary = salary;
            this.Department = department;
            this.Specialization = specialization;
            Console.WriteLine("Engineer Constructor with six param\"");
        }
        public Engineer(string specialization)
        {
            this.Specialization = specialization;
            Console.WriteLine("Engineer Constructor with one param");
        }

        ~Engineer()
        {
            Console.WriteLine("Engineer Destructor");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Specialization: {this.Specialization}");
        }
    }
}