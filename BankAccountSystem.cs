using System;  

class BankAccount  
{  
    public static string BankName { get; set; }  
    private static int totalAccounts = 0;  
    public readonly int AccountNumber;  
    public string AccountHolderName { get; set; }  
    private double Balance { get; set; }  

    public BankAccount(int accountNumber, string accountHolderName, double initialBalance)  
    {  
        this.AccountNumber = accountNumber;  
        this.AccountHolderName = accountHolderName;  
        this.Balance = initialBalance;  
        totalAccounts++;  
    }  

    public static void GetTotalAccounts()  
    {  
        Console.WriteLine("Total Accounts: " + totalAccounts);  
    }  

    public double GetBalance()  
    {  
        return Balance;  
    }  

    public void SetBalance(double balance)  
    {  
        if (balance >= 0)  
        {  
            Balance = balance;  
        }  
        else  
        {  
            Console.WriteLine("Invalid balance. Please enter a non-negative value.");  
        }  
    }  

    public void DisplayDetails()  
    {  
        if (this is BankAccount)  
        {  
            Console.WriteLine("Bank Account Details:");  
            Console.WriteLine("Bank Name: " + BankName);  
            Console.WriteLine("Account Number: " + AccountNumber);  
            Console.WriteLine("Account Holder Name: " + AccountHolderName);  
            Console.WriteLine("Balance: " + Balance);  
        }  
        else  
        {  
            Console.WriteLine("The object is not an instance of the BankAccount class.");  
        }  
    }  
}  

class BankAccountSystem  
{  
    public static void Main()  
    {  
        BankAccount.BankName = "ICICI Bank";  
        BankAccount account1 = new BankAccount(001, "vansh verma", 2000);  
        BankAccount account2 = new BankAccount(002, "yash", 3500);  
        
        account1.DisplayDetails();  
        account2.DisplayDetails();  
        BankAccount.GetTotalAccounts();  
    }  
}  
