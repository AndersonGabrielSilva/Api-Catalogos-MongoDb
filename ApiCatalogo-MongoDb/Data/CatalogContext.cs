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
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            //Configurando Dados de Produtos
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));

            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get;}
    }
}
