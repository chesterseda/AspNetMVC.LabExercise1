using System;
using System.Collections.Generic;
using AspDotNet.LabExercise1.Models;

namespace AspDotNet.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Makita Drill",
                Description = "Metric drill and dcrew bit set",
                Quantity = 3,
                Price = 3_500M
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Bosch Saw",
                Description = "Powerful motor circular saw",
                Quantity = 2,
                Price = 4_700M
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "Milwaukee Jackhammer",
                Description = "Demolition & breaker hammer",
                Quantity = 1,
                Price = 21_000M
            });

            products.Add(new Product()
            {
                Id = 4,
                Name = "Dewalt Angle Grinder",
                Description = "Brushless cordless small grinder",
                Quantity = 4,
                Price = 2_400M
            });

            products.Add(new Product()
            {
                Id = 5,
                Name = "Ingco Speed Cutter",
                Description = "No-load speed: 3800rpm",
                Quantity = 3,
                Price = 7_000M
            });
        }

        public List<Product> GetCatalog()
        {
            return products;
        }

        public decimal GetGrandTotal()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.TotalAmount;
            }
            return total;
        }
    }
}
