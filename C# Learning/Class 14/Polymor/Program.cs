using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Another derived class
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism: a single method behaves differently based on the object's type.
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.MakeSound(); // Output: Some generic animal sound
            myDog.MakeSound();    // Output: Bark
            myCat.MakeSound();    // Output: Meow

            Console.ReadLine();
        }
    }
}
