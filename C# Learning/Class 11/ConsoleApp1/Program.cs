using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog
    {
        public string Name;
        public int Age;

        public void Bark()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

    class Human
    {
        public string Name;
        public int Age;
        public string gender;
        public string country;

        public void Run()
        {
            Console.WriteLine($"{Name} is Running");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is Eating");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Dog object
            // Dog myDog = new Dog();
            //  myDog.Name = "Buddy";
            //  myDog.Age = 3;

            // Call the Bark method
            // myDog.Bark();

            // Display dog's information
            // Console.WriteLine($"My dog's name is {myDog.Name} and he is {myDog.Age} years old.");

            Human myHuman = new Human();

            myHuman.Name = "Maaz";
            myHuman.Age = 16;
            myHuman.gender = "Male";
            myHuman.country = "Pakistan";


            myHuman.Run();

            myHuman.Eat();

            Console.WriteLine($"My name is {myHuman.Name} and i am {myHuman.Age} years old. i am {myHuman.gender} and i am living in {myHuman.country}.");
            Console.ReadKey();
        }
    }
}
