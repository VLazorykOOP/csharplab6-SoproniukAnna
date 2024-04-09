
using Lab5CSharp;
using Lab6CSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("         Lab6 C# ");
        Console.WriteLine("         Task 1 ");
        List<Person> people = new List<Person>()
            {
                new Person("Petro", 45),
                new Employee("Ivan", 25,"aaa", 700),
                new Worker("Taras", 32,"aaa", 1700,"bbb"),
                new Engineer("Roma", 22,"aaa", 900,"bbb","ccc")
            };
        Console.WriteLine();
        foreach (var person in people)
        {
            person.Show();
            Console.WriteLine();
        }
        Console.WriteLine();


        Console.WriteLine("         Task 2 ");

        IProduct[] products = new IProduct[]
        {
            new Toy("Teddy Bear", 15.99, "ToyCo", 3, "Plush"),
            new Book("The Adventures of Tom Sawyer", 9.99, "BookPub", 10, "Mark Twain"),
            new SportsEquipment("Football", 29.99, "SportsGear", 12),
        };

        Toy[] toys = new Toy[]
        {
            new Toy("Teddy Bear", 15.99, "ToyCo", 3, "Plush"),
            new Toy("Doll", 20.00, "Barbi", 6, "Plush"),
            new Toy("Wolf", 10.99, "ToyCo", 5, "Plush"),
        };


        foreach (var product in products)
        {
            product.DisplayInfo();
            Console.WriteLine();
        }

        Console.WriteLine("\nSearch for Toys:");
        foreach (var product in products)
        {
            if (product.IsType("Toy"))
            {
                product.DisplayInfo();
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine("         Task 3");
        foreach (var toy in toys)
        {
            toy.DisplayInfo();
            Console.WriteLine();
        }
    }
}

