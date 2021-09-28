using ApiCatalogo_MongoDb.Data;
using ApiCatalogo_MongoDb.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo_MongoDb.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext _context;

        public ProductRepository(ICatalogContext context)
        {
            _context = context;
        }

        public async Task CreateProduct(Product product)=>        
             await _context.Products.InsertOneAsync(product);
        

        public async Task<bool> DeleteProduct(string id)
        {
            //Monta o filtro
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(product => product.Id, id);

            DeleteResult deleteResult = await _context.Products.DeleteManyAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;

        }

        public async Task<bool> UpdateProduct(Product product)
        {
            //Busca o Produto pelo Id e Atualiza
            var updateResult = await _context.Products.ReplaceOneAsync(
                    filter: prod=> prod.Id == product.Id, 
                    replacement:product);

            return updateResult.IsAcknowledged
                && updateResult.ModifiedCount > 0;
        }


        public async Task<Product> GetProduct(string id) =>
            await _context.Products.Find(p => p.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            //Monta o filtro
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(product => product.Category, categoryName);

            return await _context.Products.Find(filter).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.ElemMatch(product => product.Name, name);

            return await _context.Products.Find(filter).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProducts()=>
            await _context.Products.Find(p => true).ToListAsync();

    }
}
