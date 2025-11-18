using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("123 Dasiy Street", "Dunedin", "Otago", "New Zealand");
        Customer customer1 = new Customer("Samuel Gregson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Rainbow Necklace", 9, 15.99, 3));
        order1.AddProduct(new Product("Sunflower Ring", 11, 10.00, 2));

        Address address2 = new Address("45 Bumble Bee Lane", "Salt Lake City", "Utah", "USA");
        Customer customer2 = new Customer("Lisa Goodall", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Honey Bee Studs", 13, 20.00, 1));
        order2.AddProduct(new Product("Rose Hair Clips", 101, 7.99, 4));

        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Order Price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine("");


        }





    }
}