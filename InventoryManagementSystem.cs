using System;

class ItemNode
{
    public string ItemName { get; set; }
    public int ItemID { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public ItemNode Next { get; set; }

    public ItemNode(string itemName, int itemId, int quantity, double price)
    {
        ItemName = itemName;
        ItemID = itemId;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class InventoryManagement
{
    private ItemNode head;

    public InventoryManagement()
    {
        head = null;
    }

    public void AddItemAtStart(string itemName, int itemId, int quantity, double price)
    {
        ItemNode newNode = new ItemNode(itemName, itemId, quantity, price);
        newNode.Next = head;
        head = newNode;
        Console.WriteLine("Item added at the start.");
    }

    public void AddItemAtEnd(string itemName, int itemId, int quantity, double price)
    {
        ItemNode newNode = new ItemNode(itemName, itemId, quantity, price);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            ItemNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Console.WriteLine("Item added at the end.");
    }

    public void AddItemAtPosition(string itemName, int itemId, int quantity, double price, int position)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        ItemNode newNode = new ItemNode(itemName, itemId, quantity, price);
        if (position == 1)
        {
            newNode.Next = head;
            head = newNode;
            Console.WriteLine("Item added at position 1.");
            return;
        }

        ItemNode current = head;
        int count = 1;
        while (current != null && count < position - 1)
        {
            current = current.Next;
            count++;
        }

        if (current == null)
        {
            Console.WriteLine("Position out of bounds.");
            return;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
        Console.WriteLine($"Item added at position {position}.");
    }

    public void RemoveItemById(int itemId)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        if (head.ItemID == itemId)
        {
            head = head.Next;
            Console.WriteLine("Item removed.");
            return;
        }

        ItemNode current = head;
        while (current.Next != null && current.Next.ItemID != itemId)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Item not found.");
        }
        else
        {
            current.Next = current.Next.Next;
            Console.WriteLine("Item removed.");
        }
    }

    public void UpdateQuantityById(int itemId, int newQuantity)
    {
        ItemNode current = head;
        while (current != null)
        {
            if (current.ItemID == itemId)
            {
                current.Quantity = newQuantity;
                Console.WriteLine("Quantity updated.");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void SearchById(int itemId)
    {
        ItemNode current = head;
        while (current != null)
        {
            if (current.ItemID == itemId)
            {
                PrintItem(current);
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void CalculateTotalInventoryValue()
    {
        double totalValue = 0;
        ItemNode current = head;
        while (current != null)
        {
            totalValue += current.Price * current.Quantity;
            current = current.Next;
        }
        Console.WriteLine($"Total Inventory Value: {totalValue:F2}");
    }

    private void PrintItem(ItemNode item)
    {
        Console.WriteLine($"Item Name: {item.ItemName}, ID: {item.ItemID}, Quantity: {item.Quantity}, Price: {item.Price:F2}");
    }

    public void DisplayInventory()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        ItemNode current = head;
        while (current != null)
        {
            PrintItem(current);
            current = current.Next;
        }
    }
}

class InventoryManagementSystem
{
    static void Main()
    {
        InventoryManagement inventory = new InventoryManagement();

        inventory.AddItemAtEnd("Laptop", 101, 5, 1200);
        inventory.AddItemAtEnd("Phone", 102, 10, 700);
        inventory.AddItemAtStart("Tablet", 103, 7, 300);
        inventory.AddItemAtPosition("Monitor", 104, 3, 150, 2);

        Console.WriteLine("Initial Inventory:");
        inventory.DisplayInventory();

        inventory.RemoveItemById(102);
        Console.WriteLine("After Removing Item with ID 102:");
        inventory.DisplayInventory();

        inventory.UpdateQuantityById(101, 8);
        Console.WriteLine("After Updating Quantity of Item with ID 101:");
        inventory.DisplayInventory();

        Console.WriteLine("Searching for Item with ID 103:");
        inventory.SearchById(103);

        Console.WriteLine("Total Inventory Value:");
        inventory.CalculateTotalInventoryValue();
    }
}
