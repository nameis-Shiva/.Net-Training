using System;

abstract class Account
{
     public int AccountNumber { get; set; }
    public string CustomerName { get; set; }

    public double Balance{get; protected set;}

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Account :{AccountNumber}");
        Console.WriteLine($"Customer :{CustomerName}");
        Console.WriteLine($"Balance :{Balance}");
    }

    public abstract void CalculateInterest();

}

class SavingsAccount : Account
{
    public override void Withdraw(double amount)
    {
        if(amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdraw :{amount}");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public override void CalculateInterest()
    {
        double interest = Balance*0.5;
        Balance += interest;

        Console.WriteLine($"Interest Added :{interest}");
        Console.WriteLine($"Updated Balance :{Balance}");
    }
}

class CurrentAccount : Account
{
    public override void Withdraw(double amount)
    {
        Balance -= amount;
        Console.WriteLine($"Withdraw :{amount}");
        Console.WriteLine($"Remaining Balance :{Balance}");
    }

    public override void CalculateInterest()
    {
        Console.WriteLine("Current Account does not provide interest");
    }
}

class Program
{
    static void Main()
    {
        Account acc = new SavingsAccount();

        acc.AccountNumber = 1001;
        acc.CustomerName = "Krishna";

        acc.Deposit(50000);

        Console.WriteLine("---------------------------");
        Console.WriteLine("Account Details");
        Console.WriteLine("---------------------------");

        acc.DisplayDetails();
        acc.CalculateInterest();
        Console.WriteLine("---------------------------");

    }
}