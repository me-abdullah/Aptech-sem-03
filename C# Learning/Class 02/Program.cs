using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            Console.WriteLine("Hello we are learning C#");
            
            // Variables & Data Types
            int age = 25;
            Console.WriteLine(age);

            char letter = 'A';
            Console.WriteLine(letter);

            string myText = "Hello";
            Console.WriteLine(myText);

            bool mybool = false;
            Console.WriteLine(mybool);

            double myDoubleNum = 5.99;
            Console.WriteLine(myDoubleNum);

            // User Input

            Console.WriteLine("Enter your Name:");

            string userName = Console.ReadLine();

            Console.WriteLine($"Name is: {userName}");
            Console.ReadKey();
        }
    }
}
