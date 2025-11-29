using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address addr1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address addr2 = new Address("456 Queen St", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("John Doe", addr1);
        Customer cust2 = new Customer("Jane Smith", addr2);

        // Create products
        Product p1 = new Product("Laptop", "L001", 999.99, 1);
        Product p2 = new Product("Mouse", "M001", 25.50, 2);
        Product p3 = new Product("Keyboard", "K001", 45.00, 1);
        Product p4 = new Product("Headphones", "H001", 75.00, 1);
        Product p5 = new Product("USB-C Cable", "C001", 10.00, 3);

        // Create orders
        Order order1 = new Order(cust1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Order order2 = new Order(cust2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        // Display order info
        Order[] orders = { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Price: ${order.TotalPrice():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
