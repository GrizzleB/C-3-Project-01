using System.Collections.Generic;

namespace GuitarShop.Models
{
    public class DB
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    Name = "Fender Stratocaster",
                    Price = (decimal)699.00,
                    Description = "Ex0 Strat"
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Gibson Les Paul",
                    Price = (decimal)1199.00,
                    Description = "Ex1 Les Paul"
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Gibson SG",
                    Price = (decimal)2517.00,
                    Description = "Ex2 SG"
                },
                new Product
                {
                    ProductID = 4,
                    Name = "Yamaha FG700S",
                    Price = (decimal)489.99,
                    Description = "Ex3 Yamaha"
                },
                new Product
                {
                    ProductID = 5,
                    Name = "Washburn D10S",
                    Price = (decimal)299.00,
                    Description = "Ex4 Washburn"
                },
                new Product
                {
                    ProductID = 6,
                    Name = "Rodriguez Caballero 11",
                    Price = (decimal)415.00,
                    Description = "Ex5 Caballero"
                },
                new Product
                {
                    ProductID = 7,
                    Name = "Fender Precision",
                    Price = (decimal)799.99,
                    Description = "Ex6 Precision"
                },
                new Product
                {
                    ProductID = 8,
                    Name = "Hofner Icon",
                    Price = (decimal)499.99,
                    Description = "Ex7 Hofner"
                },
                new Product
                {
                    ProductID = 9,
                    Name = "Ludwig 5-piece Drum Set with Cymbals",
                    Price = (decimal)699.99,
                    Description = "Ex8 Ludwig"
                },
                new Product
                {
                    ProductID = 10,
                    Name = "Tama 5-Piece Drum Set with Cymbals",
                    Price = (decimal)799.99,
                    Description = "Ex9 Tama"
                }
            };
            return products;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = DB.GetProducts();
            foreach (Product p in products)
            {
                if (p.Slug == slug)
                {
                    return p;
                }
            }
            return null;
        }
    }
}