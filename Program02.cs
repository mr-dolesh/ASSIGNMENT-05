using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSIGNMENT_05
{
    internal class Program02
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
        }
    }
}
