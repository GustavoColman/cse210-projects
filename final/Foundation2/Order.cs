using System;
using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; set; } = new List<Product>();
    public Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal TotalPrice()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.TotalCost();
        }
        return total + (Customer.IsUSA() ? 5m : 35m);
    }

    public string PackingLabel()
    {
        var label = "";
        foreach (var product in Products)
        {
            label += $"{product.Name}, {product.ProductId}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.FullAddress()}";
    }
}