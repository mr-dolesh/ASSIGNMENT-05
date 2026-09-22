using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string msg) : base(msg) { }
}

class Program
{
    static void Main()
    {
        double balance = 0, amount = 0;

        try
        {
            Console.Write("Enter account balance: ");
            balance = double.Parse(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            amount = double.Parse(Console.ReadLine());

            if (amount > balance)
                throw new InsufficientBalanceException("Insufficient balance!");

            balance -= amount;
            Console.WriteLine($"Withdrawal successful. Remaining balance: {balance}");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed. Thank you for using the ATM.");
        }
    }
}