using System;

class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order placed";
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Order ID: " + OrderId);
        Console.WriteLine("Order Date: " + OrderDate.ToShortDateString());
        Console.WriteLine("Status: " + GetOrderStatus());
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order shipped";
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Tracking Number: " + TrackingNumber);
    }
}

class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order delivered";
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Delivery Date: " + DeliveryDate.ToShortDateString());
    }
}

class OnlineOrderManagement
{
    static void Main()
    {
        Order order = new Order(1, DateTime.Now.AddDays(-2));
        ShippedOrder shippedOrder = new ShippedOrder(102, DateTime.Now.AddDays(-1), "Tracking23");
        DeliveredOrder deliveredOrder = new DeliveredOrder(103, DateTime.Now.AddDays(-7), "Tracking26", DateTime.Now);

        order.DisplayInfo();
        Console.WriteLine();
        shippedOrder.DisplayInfo();
        Console.WriteLine();
        deliveredOrder.DisplayInfo();
    }
}
