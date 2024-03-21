using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6CSharp
{
    internal class Book: IProduct
    {

        public Book(string name, double price, string manufacturer, int ageGroup, string author)
        {
            this.name = name;
            this.price = price;
            this.manufacturer = manufacturer;
            this.ageGroup = ageGroup;
            this.author = author;
        }

        public string name { get; set; }
        public double price { get; set; }
        public string manufacturer { get; set; } 
        public int ageGroup { get; set; }
        public string author { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine($"Book: {name}, Price: {price}, Manufacturer: {manufacturer}, Age Group: {ageGroup}, Author: {author}");
        }

        public  bool IsType(string type)
        {
            return type.Equals("Book", StringComparison.OrdinalIgnoreCase);
        }
    }
}
