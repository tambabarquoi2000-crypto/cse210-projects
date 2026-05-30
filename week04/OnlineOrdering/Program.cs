using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        Address customer1Address = new Address("Gorzohn", "Paynesville", "Montserrado", "Liberia");
        Customer customer1 = new Customer("John", customer1Address);
        Order order1 = new Order(customer1);
        order1.AddToCart(new Product("Jeans", "Js-001", 11.50, 11));
        order1.AddToCart(new Product("Jordan", "J-250", 25, 4));
        order1.AddToCart(new Product("Bag", "bg-1100", 10, 2));

        Console.WriteLine("[Packaging Label]");
        Console.WriteLine(order1.GetPackagingLabel());
        Console.WriteLine("--------------");
        Console.WriteLine("[shipping Label]");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("--------------");
        Console.WriteLine($"Total Cost: ${order1.ClcTotalCost()}");

        Console.WriteLine();

        Address customer2Address = new Address("101R4", "Oklay", "California", "USA");
        Customer customer2 = new Customer("Bestman", customer2Address);
        Order order2 = new Order(customer2);
        order2.AddToCart(new Product("iPhone14", "IMEI-034", 350, 1));
        order2.AddToCart(new Product("Bluetooth", "E-540", 100, 2));
        order2.AddToCart(new Product("Bag", "bg-1100", 10, 2));

        Console.WriteLine("[Packaging Label]");
        Console.WriteLine(order2.GetPackagingLabel());
        Console.WriteLine("--------------");
        Console.WriteLine("[shipping Label]");
        Console.WriteLine($"{order2.GetShippingLabel()}");
        Console.WriteLine("--------------");
        Console.WriteLine($"Total Cost: ${order2.ClcTotalCost()}");

    }
}