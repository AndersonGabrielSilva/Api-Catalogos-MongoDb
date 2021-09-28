using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo_MongoDb.Entities
{
    public class Product
    {
        [BsonId]//Define a chave do Documento
        [BsonRepresentation(BsonType.ObjectId)]//Tipo do Dado
        public string Id { get; set; }
        
        [BsonElement("Name")]//Informa qual o nome do elemento no Json do Documento.(Semelhante ao Column Name do entity)
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }

}
