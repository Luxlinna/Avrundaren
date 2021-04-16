using System;
using System.Collections.Generic;
using System.Linq;

namespace Avrundaren
{
    class Program
    {
        static void Main(string[] args)
        {
            double results;

            Console.Write("Please enter decimal number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPlease enter another decimal number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPlease enter the operation: ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                results = Math.Round(num1, 5) + Math.Round(num2, 5);
                Console.WriteLine("\nThe result is: " + Math.Round(num1, 5) + " + " + Math.Round(num2, 5) + " = " + Math.Round(results, 3));
                Console.ReadKey();
            } else if (op == "-")
            {
                results = Math.Round(num1, 5) - Math.Round(num2, 5);
                Console.WriteLine("\nThe result is: " + Math.Round(num1, 5) + " - " + Math.Round(num2, 5) + " = " + Math.Round(results, 3));
                Console.ReadKey();
            } else if (op == "*")
            {
                results = Math.Round(num1, 5) * Math.Round(num2, 5);
                Console.WriteLine("\nThe result is: " + Math.Round(num1, 5) + " * " + Math.Round(num2, 5) + " = " + Math.Round(results, 3));
                Console.ReadKey();
            } else if (op == "/")
            {
                results = Math.Round(num1, 5) / Math.Round(num2, 5);
                Console.WriteLine("\nThe result is: " + Math.Round(num1, 5) + " / " + Math.Round(num2, 5) + " = " + Math.Round(results, 3));
                Console.ReadKey();
            } else
            {
                Console.WriteLine("\n The operation is wrong !!!");
                Console.ReadKey();
            }    
        }
    }
}
