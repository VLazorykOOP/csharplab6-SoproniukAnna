using Lab6CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp
{
    internal class Person: ITask1
    {
        protected string Name { get; set; }
        internal int Age { get; set; }

        public Person()
        {
            this.Name = "Ivan";
            this.Age = 30;
            Console.WriteLine("Person Default Constructor");
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine("Person Constructor with two param");
        }

        public Person(string name)
        {
            this.Name = name;
            Console.WriteLine("Person Constructor with one param");
        }

        ~Person()
        {
            Console.WriteLine("Person Destructor");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}");
        }
    }
}