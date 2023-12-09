using System;

class Program
{
    static void Main(string[] args)
    {
         // Create addresses
        var usaAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        var nonUsaAddress = new Address("456 Oak St", "Townsville", "NSW", "Australia");

        // Create customers
        var usaCustomer = new Customer("John Doe", usaAddress);
        var nonUsaCustomer = new Customer("Jane Smith", nonUsaAddress);

        // Create products
        var product1 = new Product("Widget", "W1", 10.0, 2);
        var product2 = new Product("Gadget", "G1", 15.0, 1);

        // Create orders
        var orderProducts1 = new List<Product> { product1, product2 };
        var order1 = new Order(usaCustomer, orderProducts1);

        var orderProducts2 = new List<Product> { product1 };
        var order2 = new Order(nonUsaCustomer, orderProducts2);

        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Shipping Cost applied: {order1.ShippingCost()}");
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");



    }
}