using ApiCatalogo_MongoDb.Entities;
using MongoDB.Driver;

namespace ApiCatalogo_MongoDb.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get;}
    }
}
