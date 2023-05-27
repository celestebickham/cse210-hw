using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Product product;
        List<Order> orders = new List<Order>();

        Order order1 = new Order("Peter Bryce", "123 Main", "Rome", "NA", "Italy");
        product = new Product(1, "Totinos", 1.98, 3);
        order1.AddProduct(product);

        product = new Product(2, "Red Baron", 3.48, 4);
        order1.AddProduct(product);

        product = new Product(3, "Tony's", 2.73, 8);
        order1.AddProduct(product);

        product = new Product(4, "Tombstone", 3.44, 7);
        order1.AddProduct(product);

        orders.Add(order1);

        Order order2 = new Order("Everett Cole", "555 Orchard", "Des Moines", "IA", "US");
        product = new Product(31, "Oreos", 2.28, 8);
        order2.AddProduct(product);

        product = new Product(32, "Doughnuts", 5.48, 2);
        order2.AddProduct(product);

        product = new Product(34, "Milk", 2.44, 4);
        order2.AddProduct(product);

        orders.Add(order2);

        Order order3 = new Order("Lila Celeste", "321 Friendly Dr", "Marshalltown", "IA", "USA");
        product = new Product(12, "Dress", 21.18, 2);
        order3.AddProduct(product);

        product = new Product(22, "Hair Bows", 4.78, 3);
        order3.AddProduct(product);

        product = new Product(32, "Brush", 1.53, 2);
        order3.AddProduct(product);

        product = new Product(52, "Doll", 8.53, 2);
        order3.AddProduct(product);

        product = new Product(42, "Ford Bronco", 31765.44, 1);
        order3.AddProduct(product);

        orders.Add(order3);

        foreach (Order order in orders)
        {
            Console.WriteLine(" ---- Your Order Summary --- \n");
            Console.WriteLine(order.PackLabel());
            Console.WriteLine(order.ShipLabel());
            Console.WriteLine($"\nShipping Price: ${order.ShipCost()}");
            Console.WriteLine($"Total Price: ${order.TotalPrice()}\n");
        }
    }
}

//Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.