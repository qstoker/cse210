using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Order> orders = new List<Order>();

        for (int i = 0; i < 3; i++)
        {
            Order order = new Order(
                $"Customer {i + 1}",
                $"{i + 1}{i + 1}{i + 1} Street Road",
                $"{i + 1}-ville",
                $"State of {i + 1}",
                $"Country of {i + 1}"
            );

            for (int j = 0; j < 3; j++)
            {
                order.AddProduct($"Name: {j + 1}", $"ID: {i + 1}{j + 1}{j + 1}", j + 1.0853, j + 1);
            }

            Console.WriteLine($"\nOrder {i + 1}:");
            Console.WriteLine("---------------");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("\n" + order.GetShippingLabel());
            Console.WriteLine("\nOrder Cost:\n" + order.CalculateOrderCost());
            Console.WriteLine("---------------");
        }

        // Test for America shipping price:

        Order otherOrder = new Order(
            "Me",
            "??? Street Road",
            "Something-ville",
            "State of States",
            "United States"
        );

        for (int j = 0; j < 3; j++)
        {
            otherOrder.AddProduct($"Name: {j + 1}", $"ID: ?{j + 1}{j + 1}", j + 1.0853, j + 1);
        }

        Console.WriteLine($"\nOrder ?:");
        Console.WriteLine("---------------");
        Console.WriteLine(otherOrder.GetPackingLabel());
        Console.WriteLine("\n" + otherOrder.GetShippingLabel());
        Console.WriteLine("\nOrder Cost:\n" + otherOrder.CalculateOrderCost());
        Console.WriteLine("---------------");
    }
}
