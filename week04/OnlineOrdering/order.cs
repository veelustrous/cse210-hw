using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double sum = 0;
        foreach (var p in _products)
        {
            sum += p.TotalCost();
        }
        double shipping = _customer.LivesInUSA() ? 5 : 35;
        return sum + shipping;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var p in _products)
        {
            sb.AppendLine($"Product: {p.Name}, ID: {p.ProductId}");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Ship to: {_customer.Name}\n{_customer.CustomerAddress.GetFullAddress()}";
    }
}
