using ApiCatalogo_MongoDb.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo_MongoDb.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productColletion)
        {
            bool existProduct = productColletion.Find(p => true).Any();
            if (!existProduct)
            {
                productColletion.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid().ToString().Substring(0,20),
                    Name = "Sansung A50",
                    Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's
                                    standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make
                                    a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, 
                                    remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing 
                                    Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Price = 1500m,
                    Category = "SmartPhone"
                },
                new Product()
                {
                    Id = Guid.NewGuid().ToString().Substring(0,20),
                    Name = "Motorola Razor",
                    Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's
                                    standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make
                                    a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, 
                                    remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing 
                                    Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Price = 2500m,
                    Category = "SmartPhone"
                },
                new Product()
                {
                    Id = Guid.NewGuid().ToString().Substring(0,20),
                    Name = "SmartTV",
                    Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's
                                    standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make
                                    a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, 
                                    remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing 
                                    Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Price = 2500m,
                    Category = "Home Kitchen"
                },
                new Product()
                {
                    Id = Guid.NewGuid().ToString().Substring(0,20),
                    Name = "Produto Teste",
                    Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's
                                    standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make
                                    a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, 
                                    remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing 
                                    Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Price = 2500.56m,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Id = Guid.NewGuid().ToString().Substring(0,20),
                    Name = "Motorola S5",
                    Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's
                                    standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make
                                    a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, 
                                    remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing 
                                    Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Price = 950m,
                    Category = "SmartPhone"
                },
                new Product()
                {
                    Id = Guid.NewGuid().ToString().Substring(0,20),
                    Name = "Motorola V8",
                    Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's
                                    standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make
                                    a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, 
                                    remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing 
                                    Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Price = 5500,
                    Category = "SmartPhone"
                }
            };
        }
    }
}
