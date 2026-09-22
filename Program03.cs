using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSIGNMENT_05
{
    internal class Program03
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 elements:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            try
            {
                Console.WriteLine("Enter the index of the element you want to access (0-4):");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"Element at index {index} is: {arr[index]}");

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index is out of range. Please enter an index between 0 and 4.");
            }
        }
    }
}
