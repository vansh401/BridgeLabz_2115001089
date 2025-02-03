using System;

class BankAccount {
    public string accountNumber;
    protected string accountHolder;
    private double balance;

    public BankAccount(string accountNumber, string accountHolder, double balance) {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public void Deposit(double amount) {
        if (amount > 0) {
            balance += amount;
        } else {
            Console.WriteLine("Invalid deposit amount");
        }
    }

    public void Withdraw(double amount) {
        if (amount > 0 && amount <= balance) {
            balance -= amount;
        } else {
            Console.WriteLine("insufficient balance");
        }
    }

    public double GetBalance() {
        return balance;
    }

    public void DisplayAccountDetails() {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : BankAccount {
    public double interestRate;

    public SavingsAccount(string accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance) {
        this.interestRate = interestRate;
    }

    public void DisplaySavingsAccountDetails() {
        Console.WriteLine("Interest Rate: " + interestRate);
    }
}

class BankSystem {
    public static void Main(string[] args) {
        BankAccount account1 = new BankAccount("123456789", "Vansh Verma", 10000);
        account1.DisplayAccountDetails();
        account1.Deposit(5000);
        account1.Withdraw(3000);
        Console.WriteLine("Updated Balance: " + account1.GetBalance());

        SavingsAccount savingsAccount1 = new SavingsAccount("987654321", "Yash", 15000, 4.5);
        savingsAccount1.DisplayAccountDetails();
        savingsAccount1.DisplaySavingsAccountDetails();
    }
}
