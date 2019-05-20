using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenoddproject
{
    class Program
    {
        // This is a program to find a number weather odd or even number..!
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the number:")
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("This is an Even Number");

            }
            else
            {
                Console.WriteLine("This is an Odd Number");
            }
        }
    }
}
