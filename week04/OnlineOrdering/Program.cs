using System;

class Program
{
    static void Main()
    {
        Address usaAddress = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address nonUsaAddress = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Ellio Alderson", usaAddress);
        Customer customer2 = new Customer("Kambale Edwin", nonUsaAddress);

        Product product1 = new Product("Laptop", "P100", 999.99, 1);
        Product product2 = new Product("Mouse", "P200", 19.99, 2);
        Product product3 = new Product("Nike Shoes", "P300", 49.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }
}