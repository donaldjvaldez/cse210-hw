using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("12 Jose Hazim St", "San Juan De La Maguana", "San Juan", "Dominican Republic");
        Customer customer1 = new Customer("Donald Valdez", address1);
        
        Address address2 = new Address("456 Elm St", "Provo", "UT", "USA");
        Customer customer2 = new Customer("Alice Walter", address2);

        Product p1 = new Product("A001", "Notebook", 5.99, 3);
        Product p2 = new Product("B002", "Pen", 1.49, 10);
        Product p3 = new Product("C003", "Binder", 3.99, 2);
        Product p4 = new Product("D004", "Highlighter", 0.99, 5);


        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");

        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}