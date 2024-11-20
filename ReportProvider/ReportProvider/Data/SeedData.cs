using ReportProvider.Models;
using System;
using System.Linq;

namespace ReportProvider.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // Seed Users
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User { Name = "John Doe", Email = "john.doe@example.com" },
                    new User { Name = "Jane Smith", Email = "jane.smith@example.com" },
                    new User { Name = "Chris Johnson", Email = "chris.johnson@example.com" },
                    new User { Name = "Patricia Brown", Email = "patricia.brown@example.com" },
                    new User { Name = "Michael White", Email = "michael.white@example.com" }
                );
                context.SaveChanges(); // Save Users first
            }

            // Seed Products
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Laptop", Price = 1200.99m, Stock = 50 },
                    new Product { Name = "Smartphone", Price = 699.99m, Stock = 100 },
                    new Product { Name = "Headphones", Price = 49.99m, Stock = 200 },
                    new Product { Name = "Keyboard", Price = 25.99m, Stock = 150 },
                    new Product { Name = "Mouse", Price = 15.99m, Stock = 180 },
                    new Product { Name = "Monitor", Price = 189.99m, Stock = 75 }
                );
                context.SaveChanges(); // Save Products after Users
            }

            // Seed Orders
            if (!context.Orders.Any())
            {
                context.Orders.AddRange(
                    new Order { UserId = 6, OrderDate = DateTime.Now.AddDays(-30) },
                    new Order { UserId = 7, OrderDate = DateTime.Now.AddDays(-25) },
                    new Order { UserId = 8, OrderDate = DateTime.Now.AddDays(-15) },
                    new Order { UserId = 9, OrderDate = DateTime.Now.AddDays(-10) },
                    new Order { UserId = 10, OrderDate = DateTime.Now.AddDays(-5) }
                );
                context.SaveChanges(); // Save Orders after Users and Products
            }

            // Seed OrderDetails
            if (!context.OrderDetails.Any())
            {
                context.OrderDetails.AddRange(
                    new OrderDetail { OrderId = 5, ProductId = 7, Quantity = 2, Price = 1200.99m },
                    new OrderDetail { OrderId = 6, ProductId = 7, Quantity = 1, Price = 699.99m },
                    new OrderDetail { OrderId = 7, ProductId = 9, Quantity = 3, Price = 49.99m },
                    new OrderDetail { OrderId = 8, ProductId = 10, Quantity = 5, Price = 25.99m },
                    new OrderDetail { OrderId = 9, ProductId = 11, Quantity = 2, Price = 15.99m },
                    new OrderDetail { OrderId = 9, ProductId = 12, Quantity = 1, Price = 189.99m }
                );
                context.SaveChanges(); // Save OrderDetails after Orders and Products
            }

            // Seed Reviews
            if (!context.Reviews.Any())
            {
                context.Reviews.AddRange(
                    new Review { ProductId = 7, UserId = 6, Comment = "Excellent laptop!", Rating = 5 },
                    new Review { ProductId = 8, UserId = 6, Comment = "Great value for the price.", Rating = 4 },
                    new Review { ProductId = 10, UserId = 6, Comment = "Good sound quality.", Rating = 4 },
                    new Review { ProductId = 10, UserId = 7, Comment = "Decent keyboard.", Rating = 3 },
                    new Review { ProductId = 9, UserId = 10, Comment = "Not the best mouse.", Rating = 2 }
                );
                context.SaveChanges(); // Save Reviews after Users and Products
            }

            // Seed Inventory
            if (!context.Inventory.Any())
            {
                context.Inventory.AddRange(
                    new Inventory { ProductId = 7, Quantity = 50 },
                    new Inventory { ProductId = 8, Quantity = 100 },
                    new Inventory { ProductId = 9, Quantity = 200 },
                    new Inventory { ProductId = 10, Quantity = 150 },
                    new Inventory { ProductId = 11, Quantity = 180 },
                    new Inventory { ProductId = 12, Quantity = 75 }
                );
                context.SaveChanges(); // Save Inventory after Products
            }
        }
    }
}
