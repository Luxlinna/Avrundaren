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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Skriva in decimaltal: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nSkriva in annat decimaltal: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nSkriva in operatör tecknet: ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                results = Math.Round(num1, 5) + Math.Round(num2, 5);
                Console.WriteLine("\nResultatet är : " + Math.Round(num1, 5) + " + " + Math.Round(num2, 5) + " = " + Math.Round(results, 3));
                Console.ReadKey();
            } else if (op == "-")
            {
                results = Math.Round(num1, 5) - Math.Round(num2, 5);
                Console.WriteLine("\nResultatet är : " + Math.Round(num1, 5) + " - " + Math.Round(num2, 5) + " = " + Math.Round(results, 3));
                Console.ReadKey();
            } else if (op == "*")
            {
                results = Math.Round(num1, 5) * Math.Round(num2, 5);
                Console.WriteLine("\nResultatet är : " + Math.Round(num1, 5) + " * " + Math.Round(num2, 5) + " = " + Math.Round(results, 3));
                Console.ReadKey();
            } else if (op == "/")
            {
                results = Math.Round(num1, 5) / Math.Round(num2, 5);
                Console.WriteLine("\nResultatet är : " + Math.Round(num1, 5) + " / " + Math.Round(num2, 5) + " = " + Math.Round(results, 3));
                Console.ReadKey();
            } else
            {
                Console.WriteLine("\nOperatör tecknet är fel !!!");
                Console.ReadKey();
            }    
        }
    }
}
