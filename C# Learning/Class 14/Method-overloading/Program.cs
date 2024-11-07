using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading
{
    class Program
    {
        // Method with no parameters
        public void PrintMessage()
        {
            Console.WriteLine("Hello, World!");
        }

        // Method with one parameter
        public void PrintMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // Method with two parameters
        public void PrintMessage(string message, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Message: " + message);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            // Calling different overloaded versions of PrintMessage
            program.PrintMessage();                   // Output: Hello, World!
            program.PrintMessage("Hello, C#!");       // Output: Message: Hello, C#!
            program.PrintMessage("Repeat this", 3);   // Output: Message: Repeat this (printed 3 times)

            Console.ReadLine();
        }
    }
}
