using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6CSharp
{
    internal class Toy : IProduct, IEnumerator
    {
        private string[] toyNames = { "Teddy Bear", "LEGO Set", "Doll", "Action Figure" };
        private int position = -1;

        public Toy(string name, double price, string manufacturer, int ageGroup, string material)
        {
            this.name = name;
            this.price = price;
            this.manufacturer = manufacturer;
            this.ageGroup = ageGroup;
            this.material = material;
        }

        public string name { get; set; }
        public double price { get; set; }
        public string manufacturer { get; set; }
        public int ageGroup { get; set; } 
        public string material { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Toy: {name}, Price: {price}, Manufacturer: {manufacturer}, Material: {material}, Age Group: {ageGroup}");
        }

        public bool IsType(string type)
        {
            return type.Equals("Toy", StringComparison.OrdinalIgnoreCase);
        }

        public bool MoveNext()
        {
            position++;
            return (position < toyNames.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return toyNames[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}
