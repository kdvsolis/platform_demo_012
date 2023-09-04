using Microsoft.EntityFrameworkCore;
using PlatformDemo.Data.Models;
using System;
using System.Linq;

namespace PlatformDemo.Data
{
    /// <summary>
    /// Provides methods to seed data into the database using Entity Framework Core's ModelBuilder.
    /// </summary>
    public static class DataSeeder
    {
        /// <summary>
        /// Seeds sample customer and order data into the database using the provided ModelBuilder.
        /// </summary>
        /// <param name="modelBuilder">The ModelBuilder instance.</param>
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            // Generate sample customer data
            var customers = Enumerable.Range(1, 15).Select(i => new Customer
            {
                CustomerId = i,
                Name = $"Customer {i}",
                PhoneNumber = $"555-123-{i.ToString("D2")}"
            }).ToList();

            modelBuilder.Entity<Customer>().HasData(customers);

            // Generate sample order data
            var orders = new List<Order>();

            foreach (var customer in customers)
            {
                var numOrders = new Random().Next(0, 5);

                for (var i = 1; i <= numOrders; i++)
                {
                    orders.Add(new Order
                    {
                        OrderId = orders.Count + 1,
                        OrderNumber = $"Order-{customer.CustomerId}-{i}",
                        Amount = new Random().Next(10, 500),
                        CustomerId = customer.CustomerId
                    });
                }
            }

            modelBuilder.Entity<Order>().HasData(orders);
        }
    }
}
