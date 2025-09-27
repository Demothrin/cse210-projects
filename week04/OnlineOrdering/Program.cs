using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("184 Fake Road", "Fake City", "Fake State", "USA");
        Customer customer1 = new Customer("David Chandler", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Apples", 12567, 0.67f, 18));
        order1.AddProduct(new Product("FlatScreen TV", 16789, 867.35f, 1));

        Address address2 = new Address("54 Ingleton Road", "Delly", "Hampton", "England");
        Customer customer2 = new Customer("Elli Muffin", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Raisens", 16973, 0.35f, 157));
        order2.AddProduct(new Product("Couch", 15899, 67.93f, 2));
        order2.AddProduct(new Product("Orange", 56999, 1.65f, 1));

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Shipping Cost: ${order1.ShippingPrice():0.00}");
        Console.WriteLine($"Total Price: ${order1.FinalCost():0.00}\n");

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Shipping Cost: ${order2.ShippingPrice():0.00}");
        Console.WriteLine($"Total Price: ${order2.FinalCost():0.00}\n");
    }
}