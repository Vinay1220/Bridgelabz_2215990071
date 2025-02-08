using System;

// Base class (Superclass)
public class Order
{
    public int OrderId { get; set; }
    public string OrderDate { get; set; }

    public Order(int orderId, string orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order placed.";
    }

    public virtual void DisplayOrderDetails()
    {
        Console.WriteLine("Order ID: " + OrderId);
        Console.WriteLine("Order Date: " + OrderDate);
        Console.WriteLine("Status: " + GetOrderStatus());
    }
}

// Subclass ShippedOrder (Inherits Order)
public class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    public ShippedOrder(int orderId, string orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order shipped.";
    }

    public override void DisplayOrderDetails()
    {
        base.DisplayOrderDetails();
        Console.WriteLine("Tracking Number: " + TrackingNumber);
    }
}

// Subclass DeliveredOrder (Inherits ShippedOrder)
public class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate { get; set; }

    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order delivered.";
    }

    public override void DisplayOrderDetails()
    {
        base.DisplayOrderDetails();
        Console.WriteLine("Delivery Date: " + DeliveryDate);
    }
}

// Main class to test multilevel inheritance
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Order Details ===");
        Order order = new Order(1001, "2025-02-08");
        order.DisplayOrderDetails();
        Console.WriteLine();

        Console.WriteLine("=== Shipped Order Details ===");
        ShippedOrder shippedOrder = new ShippedOrder(1002, "2025-02-07", "TRK12345");
        shippedOrder.DisplayOrderDetails();
        Console.WriteLine();

        Console.WriteLine("=== Delivered Order Details ===");
        DeliveredOrder deliveredOrder = new DeliveredOrder(1003, "2025-02-06", "TRK67890", "2025-02-09");
        deliveredOrder.DisplayOrderDetails();
    }
}
