using System;
using System.Collections.Generic;

interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;
    private string borrowerPersonalData;

    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    protected string BorrowerPersonalData
    {
        get { return borrowerPersonalData; }
        set { borrowerPersonalData = value; }
    }
    protected LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }
    public abstract int GetLoanDuration();

    public virtual void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + itemId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
}

class Book : LibraryItem, IReservable
{
    public Book(int itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 15;
    }
    public void ReserveItem()
    {
        Console.WriteLine("Book reserved.");
    }
    public bool CheckAvailability()
    {
        return true;
    }
    public override void GetItemDetails()
    {
        base.GetItemDetails();
        Console.WriteLine("Loan Duration: " + GetLoanDuration() + " days");
    }
}

class Magazine : LibraryItem, IReservable
{
    public Magazine(int itemId, string title, string author)
        : base(itemId, title, author) { }
    public override int GetLoanDuration()
    {
        return 7;
    }
    public void ReserveItem()
    {
        Console.WriteLine("Magazine reserved.");
    }
    public bool CheckAvailability()
    {
        return true;
    }
    public override void GetItemDetails()
    {
        base.GetItemDetails();
        Console.WriteLine("Loan Duration: " + GetLoanDuration() + " days");
    }
}

class DVD : LibraryItem, IReservable
{
    public DVD(int itemId, string title, string author)
        : base(itemId, title, author) { }
    public override int GetLoanDuration()
    {
        return 14;
    }
    public void ReserveItem()
    {
        Console.WriteLine("DVD reserved.");
    }
    public bool CheckAvailability()
    {
        return true;
    }
    public override void GetItemDetails()
    {
        base.GetItemDetails();
        Console.WriteLine("Loan Duration: " + GetLoanDuration() + " days");
    }
}

class LibraryManagementSystem
{
    static void Main()
    {
        List<LibraryItem> libraryItems = new List<LibraryItem>
        {
            new Book(007, "James Bond", "Ian Fleming"),
            new Magazine(001, "National Geographic", "Various Authors"),
            new DVD(003, "Inception", "Christopher Nolan")
        };

        foreach (LibraryItem item in libraryItems)
        {
            item.GetItemDetails();
            Console.WriteLine();

            IReservable reservableItem = item as IReservable; 
            if (reservableItem != null)
            {
                reservableItem.ReserveItem();
                Console.WriteLine("Available: " + reservableItem.CheckAvailability());
            }

            Console.WriteLine();
        }
    }
}
