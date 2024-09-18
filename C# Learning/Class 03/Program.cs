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
            // Array

            string[] user_arr = ["Abdullah", "Hassan", "Irfan", "Afzal"];
            Console.WriteLine(user_arr);
            foreach (var user_arry in user_arr)
            {
                Console.WriteLine(user_arry);
            }

            int[] numarray = [10, 9, 8, 7, 6];

            foreach (var num_arry in numarray)
            {
                Console.WriteLine(num_arry);
            }
        }
    }
}
