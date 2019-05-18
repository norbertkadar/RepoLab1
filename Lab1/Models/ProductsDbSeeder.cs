using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class ProductsDbSeeder
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any flowers.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Cars",
                    Description = "Toy RC",
                    Category = "children",
                    Price = 12.5
                },
                new Product
                {
                    Name = "bout",
                    Description = "Toy RC",
                    Category = "children",
                    Price = 23.9
                }
            );
            context.SaveChanges();
        }
    }
}
