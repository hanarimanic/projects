using System;

using DAL.Models;
namespace DAL
{
	public static class DbMethods //metode za rad s bazom //static da se ne mora instancirati
	{
        #region Customers
        //READ
        public static List<Customer> GetCustomers()
        {
            List<Customer> customer = new List<Customer>();
            try
            {
                using (var context = new SneakerShopContext())
                {
                    customer.AddRange(context.Customers);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return customer;
        }

        //CREATE
        public static void AddCustomer(Customer customer)
        {
            try
            {
                using (var context = new SneakerShopContext())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //UPDATE
        public static void UpdateCustomer(Customer customer)
        {
            try
            {
                using (var context = new SneakerShopContext())
                {
                    Customer customerFromBase = context.Customers.FirstOrDefault(
                        x => x.CustomerId == customer.CustomerId);
                    if (customerFromBase != null)
                    {
                        customerFromBase.CustomerName = customer.CustomerName;
                        customerFromBase.CustomerSurname = customer.CustomerSurname;
                        customerFromBase.Email = customer.Email; 
                        customerFromBase.Phone = customer.Phone; 
                        context.SaveChanges(); 
                    }
                    else
                    {
                        throw new Exception("Customer not found in database!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //brisanje prijatelja
        public static void DeleteCustomer(int id)
        {
            try
            {
                using (var context = new SneakerShopContext())
                {
                    Customer customerFromBase = context.Customers.FirstOrDefault(
                        x => x.CustomerId == id);
                    if (customerFromBase != default)
                    {
                        context.Customers.Remove(customerFromBase);
                        context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                    }
                    else
                    {
                        throw new Exception("Customer not found in database!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        #endregion

        #region Products
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (var context = new SneakerShopContext())
                {
                    products.AddRange(context.Products);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return products;
        }

        // CREATE Product
        public static void AddProduct(Product product)
        {
            try
            {
                using (var context = new SneakerShopContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        // UPDATE Product
        public static void UpdateProduct(Product product)
        {
            try
            {
                using (var context = new SneakerShopContext())
                {
                    Product productFromBase = context.Products.FirstOrDefault(
                        x => x.ProductId == product.ProductId);
                    if (productFromBase != null)
                    {
                        productFromBase.ProductName = product.ProductName;
                        productFromBase.UnitPrice = product.UnitPrice;
                        productFromBase.UnitsInStock = product.UnitsInStock;
                        productFromBase.CategoryId = product.CategoryId;
                        productFromBase.Brand = product.Brand;
                        productFromBase.Size = product.Size;
                        productFromBase.Model = product.Model;
                        productFromBase.Color = product.Color;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Product not found in database!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        // DELETE Product
        public static void DeleteProduct(int id)
        {
            try
            {
                using (var context = new SneakerShopContext())
                {
                    Product productFromBase = context.Products.FirstOrDefault(
                        x => x.ProductId == id);
                    if (productFromBase != null)
                    {
                        context.Products.Remove(productFromBase);
                        context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                    }
                    else
                    {
                        throw new Exception("Product not found in database!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        #endregion

        #region Orders
        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            try
            {
                using (var context = new SneakerShopContext())
                {
                    orders.AddRange(context.Orders);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return orders;
        }

        // CREATE Order
        public static void AddOrder(Order order)
        {
            try
            {
                using (var context = new SneakerShopContext())
                {
                    context.Orders.Add(order);
                    context.SaveChanges(); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        // UPDATE Order
        public static void UpdateOrder(Order order)
        {
            try
            {
                using (var context = new SneakerShopContext())
                {
                    Order orderFromBase = context.Orders.FirstOrDefault(
                        x => x.OrderId == order.OrderId);
                    if (orderFromBase != null)
                    {
                        orderFromBase.CustomerId = order.CustomerId;
                        orderFromBase.OrderDate = order.OrderDate;
                        orderFromBase.ShipDate = order.ShipDate;
                        orderFromBase.TotalAmount = order.TotalAmount;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Order not found in database!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        // DELETE Order
        public static void DeleteOrder(int id)
        {
            try
            {
                using (var context = new SneakerShopContext())
                {
                    Order orderFromBase = context.Orders.FirstOrDefault(
                        x => x.OrderId == id);
                    if (orderFromBase != null)
                    {
                        context.Orders.Remove(orderFromBase);
                        context.SaveChanges(); 
                    }
                    else
                    {
                        throw new Exception("Order not found in database!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        #endregion
    }


}

