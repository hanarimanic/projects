using System;
namespace SneakerShopApp
{
    internal static class Menus
    {
        public static void MainMenu()
        {
            bool repeat = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("****** MENU ******");
                Console.WriteLine("* 1. Products    *");
                Console.WriteLine("* 2. Orders      *");
                Console.WriteLine("* 3. Customers   *");
                Console.WriteLine("* 4. Exit         *");
                Console.WriteLine("******************");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ProductsMenu();
                        break;
                    case "2":
                        OrdersMenu();
                        break;
                    case "3":
                        CustomersMenu();
                        break;
                    case "4":
                        return;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unknown option!");
                        repeat = true;
                        Thread.Sleep(1000);
                        break;
                }
            } while (repeat);
        }

        public static void CustomersMenu()
        {
            bool repeat = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("╔══ CUSTOMERS ══╗");
                Console.WriteLine("║ 1. Add         ║");
                Console.WriteLine("║ 2. Print       ║");
                Console.WriteLine("║ 3. Update      ║");
                Console.WriteLine("║ 4. Delete      ║");
                Console.WriteLine("║ 5. Exit        ║");
                Console.WriteLine("╚═══════════════╝");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CustomerModule.Create();
                        break;
                    case "2":
                        CustomerModule.Read();
                        break;
                    case "3":
                        CustomerModule.Update();
                        break;
                    case "4":
                        CustomerModule.Delete();
                        break;
                    case "5":
                        MainMenu();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unknown option!");
                        repeat = true;
                        Thread.Sleep(1000);
                        break;
                }
            } while (repeat);
        }
        public static void ProductsMenu()
        {
            bool repeat = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("╔═══ PRODUCTS ═══╗");
                Console.WriteLine("║ 1. Add         ║");
                Console.WriteLine("║ 2. Print       ║");
                Console.WriteLine("║ 3. Update      ║");
                Console.WriteLine("║ 4. Delete      ║");
                Console.WriteLine("║ 5. Exit        ║");
                Console.WriteLine("╚═══════════════╝");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ProductsModule.Create();
                        break;
                    case "2":
                        ProductsModule.Read();
                        break;
                    case "3":
                        ProductsModule.Update();
                        break;
                    case "4":
                        ProductsModule.Delete();
                        break;
                    case "5":
                        MainMenu();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unknown option!");
                        repeat = true;
                        Thread.Sleep(1000);
                        break;
                }
            } while (repeat);


        }
        public static void OrdersMenu()
        {
            bool repeat = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("╔══ ORDERS ══╗");
                Console.WriteLine("║ 1. Add      ║");
                Console.WriteLine("║ 2. Print    ║");
                Console.WriteLine("║ 3. Update   ║");
                Console.WriteLine("║ 4. Delete   ║");
                Console.WriteLine("║ 5. Exit     ║");
                Console.WriteLine("╚═════════════╝");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        OrderModule.Create();
                        break;
                    case "2":
                        OrderModule.Read();
                        break;
                    case "3":
                        OrderModule.Update();
                        break;
                    case "4":
                        OrderModule.Delete();
                        break;
                    case "5":
                        MainMenu();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unknown option!");
                        repeat = true;
                        Thread.Sleep(1000);
                        break;
                }
            } while (repeat);
        }

    }
}

