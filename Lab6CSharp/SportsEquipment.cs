using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6CSharp
{
    internal class SportsEquipment: IProduct
    {
        public SportsEquipment(string name, double price, string manufacturer, int ageGroup)
        {
            this.name = name;
            this.price = price;
            this.manufacturer = manufacturer;
            this.ageGroup = ageGroup;
        }

        public string name { get; set; }
        public double price { get; set; }
        public string manufacturer { get; set; }
        public int ageGroup { get; set; }

        public  void DisplayInfo()
        {
            Console.WriteLine($"Sports Equipment: {name}, Price: {price}, Manufacturer: {manufacturer}, Age Group: {ageGroup}");
        }

        public  bool IsType(string type)
        {
            return type.Equals("SportsEquipment", StringComparison.OrdinalIgnoreCase);
        }
    }
}
