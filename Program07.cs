using System;

class InvalidLoginException : Exception
{
    public InvalidLoginException(string msg) : base(msg) { }
}

class Program07
{
    static void Main()
    {
        const string VALID_USER = "admin";
        const string VALID_PASS = "password123";

        try
        {
            Console.Write("Enter username: ");
            string user = Console.ReadLine();

            Console.Write("Enter password: ");
            string pass = Console.ReadLine();

            if (user != VALID_USER || pass != VALID_PASS)
                throw new InvalidLoginException("Invalid username or password!");

            Console.WriteLine("Login successful! Welcome.");
        }
        catch (InvalidLoginException ex)
        {
            Console.WriteLine($"Login Failed: {ex.Message}");
        }
    }
}