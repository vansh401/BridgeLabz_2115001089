using System;

class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Bank Account");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: $" + Balance);
    }
}

class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Withdrawal Limit: $" + WithdrawalLimit);
    }
}

class FixedDepositAccount : BankAccount
{
    public DateTime MaturityDate { get; set; }

    public FixedDepositAccount(int accountNumber, double balance, DateTime maturityDate)
        : base(accountNumber, balance)
    {
        MaturityDate = maturityDate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Fixed Deposit Account");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Maturity Date: " + MaturityDate.ToShortDateString());
    }
}

class BankAccountSystem
{
    static void Main()
    {
        BankAccount[] accounts = new BankAccount[]
        {
            new SavingsAccount(2134, 5000.0, 3.5),
            new CheckingAccount(2133, 2000.0, 1000.0),
            new FixedDepositAccount(2135, 10000.0, DateTime.Now.AddYears(1))
        };

        foreach (var account in accounts)
        {
            account.DisplayAccountType();
            account.DisplayInfo();
            Console.WriteLine();
        }
    }
}
