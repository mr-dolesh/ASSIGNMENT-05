using System;

class Program06
{
    static void Main()
    {
        int[] marks = new int[5];
        string[] subjects = { "Math", "Science", "English", "History", "Computer" };

        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks for {subjects[i]} (0-100): ");
                marks[i] = int.Parse(Console.ReadLine());

                if (marks[i] < 0 || marks[i] > 100)
                    throw new ArgumentOutOfRangeException(
                        $"Marks for {subjects[i]} must be between 0 and 100.");
            }

            Console.WriteLine("\n--- Marks Summary ---");
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"{subjects[i]}: {marks[i]}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter numeric values only.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}