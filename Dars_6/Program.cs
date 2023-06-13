using Dars_6.Entity.Laptop;
using Dars_6.Entity.Laptop.Enums;

namespace Dars_6;

public static class Program
{
    public static void Main()
    {

        //var laptop = new Laptop();
        //laptop.Memory = new();

        

        var asus = new Laptop(
            "Tuff", 
            new DateOnly(2023,02,12),
            15000M,
            ELaptopType.Gaming,
            2.0,
            (EColorType)4,
            true);

        //asus.PrintInfo();

        asus.Screen = new Screen(32, true, EScreenType.AMOLED, 123M);
        var laptop = new Laptop(new Screen
        {
            Size = 16,
            IsTouchScreen = true,
            Price = 500,
            Type = EScreenType.IPS
        });
        //asus.Screen = screen;
        asus.PrintInfo();
        //laptop.PrintInfo();

        ////laptop = asus;

        //laptop.CloneIt(asus);
        ////laptop.PrintInfo();
        ////asus.PrintInfo();

        //Console.WriteLine(Equals(laptop,asus));
        //Console.WriteLine(laptop.GetHashCode());
        //Console.WriteLine(asus.GetHashCode());

        // Usage
        //Animal animal1 = new Animal();                      // Default constructor
        //Animal animal2 = new Animal("Leo");                 // Constructor with name parameter
        //Animal animal3 = new Animal("Max", 5);              // Constructor with name and age parameters
        //Animal animal4 = new Animal("Bella", 3, "Dog");      // Constructor with all parameters

        //animal1.PrintInfo();    // Output: Name: Unknown, Age: 0, Species: Unknown
        //animal2.PrintInfo();    // Output: Name: Leo, Age: 0, Species: Unknown
        //animal3.PrintInfo();    // Output: Name: Max, Age: 5, Species: Unknown
        //animal4.PrintInfo();    // Output: Name: Bella, Age: 3, Species: Dog

    }

    public class Test
    {
        /// <summary>
        /// Filed bu class memeberi
        /// </summary>
        private int id;

        //Property bu ham clas memeberi
        public int Getter()
        {
            return id;
        }

        public void Setter(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="id"></param>
        public Test(int id)
        {
            this.id = id;
        }


    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        // Default constructor
        public Animal() : this("Unknown")
        {
        }

        // Constructor with name parameter
        public Animal(string name) : this(name, 0)
        {
        }

        // Constructor with name and age parameters
        public Animal(string name, int age) : this(name, age, "Unknown")
        {
        }

        // Constructor with all parameters
        public Animal(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Species: {Species}");
        }
    }


       
}



