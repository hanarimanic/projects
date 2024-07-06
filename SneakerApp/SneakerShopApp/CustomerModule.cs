using System;
using DAL;
using DAL.Models;

namespace SneakerShopApp
{
    internal class CustomerModule
    {
        public static void Read()
        {
            List<Customer> customers = DbMethods.GetCustomers();
            Console.WriteLine();
            Console.WriteLine("CUSTOMERS FROM DATABASE: ");
            foreach (Customer c in customers)
            {
                Console.WriteLine($"Id: {c.CustomerId} - {c.CustomerName} {c.CustomerSurname}| Email: {c.Email} | Phone: {c.Phone}");
            }
            

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Menus.CustomersMenu();
        }

        public static void Create()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING A NEW CUSTOMER: ");
            Customer c = new Customer();
            Console.Write("Enter first name: ");
            c.CustomerName = Console.ReadLine();
            Console.Write("Enter last name: ");
            c.CustomerSurname = Console.ReadLine();
            Console.Write("Enter email: ");
            c.Email = Console.ReadLine();
            Console.Write("Enter phone: ");
            c.Phone = Console.ReadLine();
            DbMethods.AddCustomer(c);
            Console.WriteLine("Customer added to the database. Press any key to continue...");
            Console.ReadKey();
            Menus.CustomersMenu();
            
        }

        public static void Delete()
        {
            Console.WriteLine();
            Console.WriteLine("DELETING A CUSTOMER: ");
            Console.WriteLine("--------- Customers in the database -------------");
            foreach (Customer c in DbMethods.GetCustomers())
            {
                Console.WriteLine($"Id: {c.CustomerId} - {c.CustomerName} {c.CustomerSurname}| Email: {c.Email} | Phone: {c.Phone}");
            }
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter customer Id: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                DbMethods.DeleteCustomer(id);
                Console.WriteLine("Customer deleted from the database.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Menus.CustomersMenu();
        }

        public static void Update()
        {
            Console.WriteLine();
            Console.WriteLine("UPDATING A CUSTOMER: ");
            Console.WriteLine("--------- Customers in the database -------------");
            foreach (Customer c in DbMethods.GetCustomers())
            {
                Console.WriteLine($"Id: {c.CustomerId} - {c.CustomerName} {c.CustomerSurname} | Email: {c.Email} | Phone: {c.Phone}");
            }
            Console.WriteLine("------------------------------------------");
            try   
            {
                Customer c = new Customer();
                Console.Write("Enter customer Id: ");
                int id = int.Parse(Console.ReadLine());
                c.CustomerId = id;
                Console.Write("Enter first name: ");
                c.CustomerName = Console.ReadLine();
                Console.Write("Enter last name: ");
                c.CustomerSurname = Console.ReadLine();
                Console.Write("Enter email: ");
                c.Email = Console.ReadLine();
                Console.Write("Enter phone: ");
                c.Phone = Console.ReadLine();
                DbMethods.UpdateCustomer(c);
                Console.WriteLine("Customer updated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Menus.CustomersMenu();
        }
    }
}

