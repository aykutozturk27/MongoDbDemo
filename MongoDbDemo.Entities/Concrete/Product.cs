using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDbDemo.Core.Entities;
using System.Text.Json.Serialization;

namespace MongoDbDemo.Entities.Concrete
{
    public class Product : BaseEntity
    {
        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public int ProductID { get; set; }

        [BsonElement("ProductName")]
        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        [BsonElement("QuantityPerUnit")]
        [JsonPropertyName("QuantityPerUnit")]
        public string? QuantityPerUnit { get; set; }
        
        [BsonElement("UnitPrice")]
        [JsonPropertyName("UnitPrice")]
        public double UnitPrice { get; set; }

        [BsonElement("UnitsInStock")]
        [JsonPropertyName("UnitsInStock")]
        public short UnitsInStock { get; set; }
    }
}
