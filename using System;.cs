using System;
using System.Collections.Generic;

namespace OrderingSystem
{
    class Order
    {
        // Define a class to represent an item in the order
        class OrderItem
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        static List<OrderItem> orders = new List<OrderItem>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Ordering Application");
                Console.WriteLine("1. Add Item to Order");
                Console.WriteLine("2. View Order Summary");
                Console.WriteLine("3. Place Order");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItem();
                        break;
                    case "2":
                        ViewOrderSummary();
                        break;
                    case "3":
                        PlaceOrder();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddItem()
        {
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter item price: ");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price) || price <= 0)
            {
                Console.WriteLine("Invalid price. Please enter a valid positive number.");
                Console.Write("Enter item price: ");
            }

            orders.Add(new OrderItem { Name = itemName, Price = price });

            Console.WriteLine("Item added to order.");
        }

        static void ViewOrderSummary()
        {
            Console.WriteLine("Order Summary:");
            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Name}: ${order.Price}");
            }
        }

        static void PlaceOrder()
        {
            double totalPrice = 0;
            foreach (var order in orders)
            {
                totalPrice += order.Price;
            }

            Console.WriteLine($"Total Price of Order: ${totalPrice}");
            orders.Clear();
            Console.WriteLine("Order placed. Your order list is cleared.");
        }
    }
}