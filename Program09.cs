using System;
using System.IO;

class Program09
{
    static void Main()
    {
        string filePath = "students.txt";

        try
        {
            StreamWriter sw = new StreamWriter(filePath);
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter roll number: ");
                string roll = Console.ReadLine();
                sw.WriteLine($"{name},{roll}");
            }
            sw.Close();
            Console.WriteLine("Data written successfully!");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File write error: {ex.Message}");
        }

        try
        {
            StreamReader sr = new StreamReader(filePath);
            Console.WriteLine("\n--- Student Details ---");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                Console.WriteLine($"Name: {parts[0]}, Roll No: {parts[1]}");
            }
            sr.Close();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found!");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File read error: {ex.Message}");
        }
    }
}