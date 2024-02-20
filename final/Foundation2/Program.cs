using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new customer with their address
        var customer = new Customer("John Doe", new Address("123 Elm St", "Springfield", "IL", "USA"));

        // Creating a new order for the customer
        var order = new Order(customer);

        // Adding products to the order
        order.AddProduct(new Product("Laptop", "L123", 1200, 1));
        order.AddProduct(new Product("USB-C Adapter", "U456", 120, 2));

        // Displaying packing label
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel());

        // Displaying shipping label
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.ShippingLabel());

        // Displaying total price of the order
        Console.WriteLine($"\nTotal Price: {order.TotalPrice()}");
    }
}
}