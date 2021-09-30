using ApiCatalogo_MongoDb.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo_MongoDb.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            //Configurando Contexto do Banco
            var server = configuration.GetValue<string>("DatabaseSettings:ConnectionString");
            var client = new MongoClient(server);

            var namedb = configuration.GetValue<string>("DatabaseSettings:DatabaseName");
            var database = client.GetDatabase(namedb);

            //Configurando Dados de Produtos
            var collectionName = configuration.GetValue<string>("DatabaseSettings:CollectionName");
            Products = database.GetCollection<Product>(collectionName);

            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get;}
    }
}
