using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string msg) : base(msg) { }
}

class BankAccount
{
    public double Balance { get; set; }

    public BankAccount(double balance)
    {
        Balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
            throw new InsufficientFundsException(
                $"Cannot withdraw {amount}. Available balance: {Balance}");

        Balance -= amount;
        Console.WriteLine($"Withdrawal of {amount} successful. New balance: {Balance}");
    }
}

class Program08
{
    static void Run()
    {
        BankAccount account = null;
        try
        {
            Console.Write("Enter initial balance: ");
            double bal = double.Parse(Console.ReadLine());
            account = new BankAccount(bal);

            Console.Write("Enter withdrawal amount: ");
            double amt = double.Parse(Console.ReadLine());
            account.Withdraw(amt);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            if (account != null)
                Console.WriteLine($"Final Balance: {account.Balance}");
            Console.WriteLine("Bank operation ended.");
        }
    }
}