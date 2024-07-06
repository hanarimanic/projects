using System;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace SneakerShopApp
{
    internal class OrderModule
    {
        public static void Read()
        {
            List<Order> orders = DbMethods.GetOrders();
            Console.WriteLine();
            Console.WriteLine("ORDERS FROM DATABASE: ");
            foreach (Order o in orders)
            {
                Console.WriteLine($"Id: {o.OrderId} - CustomerId: {o.CustomerId} | OrderDate: {o.OrderDate.ToShortDateString()} | ShipDate: {(o.ShipDate.HasValue ? o.ShipDate.Value.ToShortDateString() : "N/A")} | TotalAmount: {o.TotalAmount}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Menus.MainMenu(); 
        }

        public static void Create()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING A NEW ORDER: ");
            Order o = new Order();
            Console.Write("Enter customer ID: ");
            o.CustomerId = int.Parse(Console.ReadLine());
            Console.Write("Enter order date (YYYY-MM-DD): ");
            o.OrderDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter ship date (YYYY-MM-DD) or leave blank if not shipped: ");
            string shipDateInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(shipDateInput))
            {
                o.ShipDate = DateTime.Parse(shipDateInput);
            }
            Console.Write("Enter total amount: ");
            o.TotalAmount = decimal.Parse(Console.ReadLine());
            DbMethods.AddOrder(o);
            Console.WriteLine("Order added to the database. Press any key to continue...");
            Console.ReadKey();
            Menus.MainMenu();
        }

        public static void Delete()
        {
            Console.WriteLine();
            Console.WriteLine("DELETING AN ORDER: ");
            Console.WriteLine("--------- Orders in the database -------------");
            foreach (Order o in DbMethods.GetOrders())
            {
                Console.WriteLine($"Id: {o.OrderId} - CustomerId: {o.CustomerId} | OrderDate: {o.OrderDate.ToShortDateString()} | ShipDate: {(o.ShipDate.HasValue ? o.ShipDate.Value.ToShortDateString() : "N/A")} | TotalAmount: {o.TotalAmount}");
            }
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter order Id: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                DbMethods.DeleteOrder(id);
                Console.WriteLine("Order deleted from the database.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Menus.MainMenu();
        }

        public static void Update()
        {
            Console.WriteLine();
            Console.WriteLine("UPDATING AN ORDER: ");
            Console.WriteLine("--------- Orders in the database -------------");
            foreach (Order o in DbMethods.GetOrders())
            {
                Console.WriteLine($"Id: {o.OrderId} - CustomerId: {o.CustomerId} | OrderDate: {o.OrderDate.ToShortDateString()} | ShipDate: {(o.ShipDate.HasValue ? o.ShipDate.Value.ToShortDateString() : "N/A")} | TotalAmount: {o.TotalAmount}");
            }
            Console.WriteLine("------------------------------------------");
            try
            {
                Order o = new Order();
                Console.Write("Enter order Id: ");
                int id = int.Parse(Console.ReadLine());
                o.OrderId = id;
                Console.Write("Enter customer ID: ");
                o.CustomerId = int.Parse(Console.ReadLine());
                Console.Write("Enter order date (YYYY-MM-DD): ");
                o.OrderDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter ship date (YYYY-MM-DD) or leave blank if not shipped: ");
                string shipDateInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(shipDateInput))
                {
                    o.ShipDate = DateTime.Parse(shipDateInput);
                }
                Console.Write("Enter total amount: ");
                o.TotalAmount = decimal.Parse(Console.ReadLine());
                DbMethods.UpdateOrder(o);
                Console.WriteLine("Order updated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Menus.MainMenu();
        }
    }
}

