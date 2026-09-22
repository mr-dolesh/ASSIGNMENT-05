using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace ASSIGNMENT_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter another number:");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine($"The result of {a} divided by {b} is: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: You cannot divide by zero.");
            }
            
        }
    }
}
