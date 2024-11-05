using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

    class Animal
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine("my animal is eating");
        }
    }

    class Dog  : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"my {name} is Barking");
        }
    }


    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"my cat name is {name} and she saying meow meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            cat.name = "Lilly";
            dog.name = "Tommy";

            dog.Bark();
            cat.Meow();

            Console.ReadKey();
        }
    }
}
