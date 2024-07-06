using System;
using DAL;
using DAL.Models;


 
namespace SneakerShopApp
{
    public class ProductsModule
    {
        public static void Read()
        {
            List<Product> products = DbMethods.GetProducts();
            Console.WriteLine();
            Console.WriteLine("PRODUCTS FROM DATABASE: ");
            foreach (Product p in products)
            {
                Console.WriteLine($"Id: {p.ProductId} - Name: {p.ProductName} | Price: {p.UnitPrice} | Stock: {p.UnitsInStock} | CategoryId: {p.CategoryId} | Brand: {p.Brand} | Size: {p.Size} | Model: {p.Model} | Color: {p.Color}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Menus.MainMenu(); 
        }

        public static void Create()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING A NEW PRODUCT: ");
            Product p = new Product();
            Console.Write("Enter product name: ");
            p.ProductName = Console.ReadLine();
            Console.Write("Enter unit price: ");
            p.UnitPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Enter units in stock: ");
            p.UnitsInStock = int.Parse(Console.ReadLine());
            Console.Write("Enter category ID: ");
            p.CategoryId = int.Parse(Console.ReadLine());
            Console.Write("Enter brand: ");
            p.Brand = Console.ReadLine();
            Console.Write("Enter size: ");
            p.Size = Console.ReadLine();
            Console.Write("Enter model: ");
            p.Model = Console.ReadLine();
            Console.Write("Enter color: ");
            p.Color = Console.ReadLine();
            DbMethods.AddProduct(p);
            Console.WriteLine("Product added to the database. Press any key to continue...");
            Console.ReadKey();
            Menus.MainMenu();
        }

        public static void Delete()
        {
            Console.WriteLine();
            Console.WriteLine("DELETING A PRODUCT: ");
            Console.WriteLine("--------- Products in the database -------------");
            foreach (Product p in DbMethods.GetProducts())
            {
                Console.WriteLine($"Id: {p.ProductId} - Name: {p.ProductName} | Price: {p.UnitPrice} | Stock: {p.UnitsInStock} | CategoryId: {p.CategoryId} | Brand: {p.Brand} | Size: {p.Size} | Model: {p.Model} | Color: {p.Color}");
            }
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter product Id: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                DbMethods.DeleteProduct(id);
                Console.WriteLine("Product deleted from the database.");
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
            Console.WriteLine("UPDATING A PRODUCT: ");
            Console.WriteLine("--------- Products in the database -------------");
            foreach (Product p in DbMethods.GetProducts())
            {
                Console.WriteLine($"Id: {p.ProductId} - Name: {p.ProductName} | Price: {p.UnitPrice} | Stock: {p.UnitsInStock} | CategoryId: {p.CategoryId} | Brand: {p.Brand} | Size: {p.Size} | Model: {p.Model} | Color: {p.Color}");
            }
            Console.WriteLine("------------------------------------------");
            try
            {
                Product p = new Product();
                Console.Write("Enter product Id: ");
                int id = int.Parse(Console.ReadLine());
                p.ProductId = id;
                Console.Write("Enter product name: ");
                p.ProductName = Console.ReadLine();
                Console.Write("Enter unit price: ");
                p.UnitPrice = decimal.Parse(Console.ReadLine());
                Console.Write("Enter units in stock: ");
                p.UnitsInStock = int.Parse(Console.ReadLine());
                Console.Write("Enter category ID: ");
                p.CategoryId = int.Parse(Console.ReadLine());
                Console.Write("Enter brand: ");
                p.Brand = Console.ReadLine();
                Console.Write("Enter size: ");
                p.Size = Console.ReadLine();
                Console.Write("Enter model: ");
                p.Model = Console.ReadLine();
                Console.Write("Enter color: ");
                p.Color = Console.ReadLine();
                DbMethods.UpdateProduct(p);
                Console.WriteLine("Product updated.");
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

