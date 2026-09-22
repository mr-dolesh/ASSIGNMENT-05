using System;
using System.IO;
using System.Collections.Generic;

class Program10
{
    static void Main()
    {
        string filePath = "marks.txt";

        try
        {
            StreamReader sr = new StreamReader(filePath);
            List<int> marks = new List<int>();
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                marks.Add(int.Parse(line));
            }
            sr.Close();

            if (marks.Count == 0)
            {
                Console.WriteLine("No marks found in the file.");
                return;
            }

            int total = 0, highest = marks[0], lowest = marks[0];
            foreach (int m in marks)
            {
                total += m;
                if (m > highest) highest = m;
                if (m < lowest) lowest = m;
            }

            double average = (double)total / marks.Count;

            Console.WriteLine($"Total Marks   : {total}");
            Console.WriteLine($"Average Marks : {average:F2}");
            Console.WriteLine($"Highest Marks : {highest}");
            Console.WriteLine($"Lowest Marks  : {lowest}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File 'marks.txt' not found!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: File contains non-numeric data!");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O Error: {ex.Message}");
        }
    }
}