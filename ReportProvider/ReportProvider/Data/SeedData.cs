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
                    new Order { UserId = 1, OrderDate = DateTime.Now.AddDays(-30) },
                    new Order { UserId = 2, OrderDate = DateTime.Now.AddDays(-25) },
                    new Order { UserId = 3, OrderDate = DateTime.Now.AddDays(-15) },
                    new Order { UserId = 4, OrderDate = DateTime.Now.AddDays(-10) },
                    new Order { UserId = 5, OrderDate = DateTime.Now.AddDays(-5) }
                );
                context.SaveChanges(); // Save Orders after Users and Products
            }

            // Seed OrderDetails
            if (!context.OrderDetails.Any())
            {
                context.OrderDetails.AddRange(
                    new OrderDetail { OrderId = 1, ProductId = 1, Quantity = 2, Price = 1200.99m },
                    new OrderDetail { OrderId = 1, ProductId = 2, Quantity = 1, Price = 699.99m },
                    new OrderDetail { OrderId = 2, ProductId = 3, Quantity = 3, Price = 49.99m },
                    new OrderDetail { OrderId = 3, ProductId = 4, Quantity = 5, Price = 25.99m },
                    new OrderDetail { OrderId = 4, ProductId = 5, Quantity = 2, Price = 15.99m },
                    new OrderDetail { OrderId = 5, ProductId = 6, Quantity = 1, Price = 189.99m }
                );
                context.SaveChanges(); // Save OrderDetails after Orders and Products
            }

            // Seed Reviews
            if (!context.Reviews.Any())
            {
                context.Reviews.AddRange(
                    new Review { ProductId = 1, UserId = 1, Comment = "Excellent laptop!", Rating = 5 },
                    new Review { ProductId = 2, UserId = 2, Comment = "Great value for the price.", Rating = 4 },
                    new Review { ProductId = 3, UserId = 3, Comment = "Good sound quality.", Rating = 4 },
                    new Review { ProductId = 4, UserId = 4, Comment = "Decent keyboard.", Rating = 3 },
                    new Review { ProductId = 5, UserId = 5, Comment = "Not the best mouse.", Rating = 2 }
                );
                context.SaveChanges(); // Save Reviews after Users and Products
            }

            // Seed Inventory
            if (!context.Inventory.Any())
            {
                context.Inventory.AddRange(
                    new Inventory { ProductId = 1, Quantity = 50 },
                    new Inventory { ProductId = 2, Quantity = 100 },
                    new Inventory { ProductId = 3, Quantity = 200 },
                    new Inventory { ProductId = 4, Quantity = 150 },
                    new Inventory { ProductId = 5, Quantity = 180 },
                    new Inventory { ProductId = 6, Quantity = 75 }
                );
                context.SaveChanges(); // Save Inventory after Products
            }
        }
    }
}
