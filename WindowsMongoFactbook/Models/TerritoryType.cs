using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace WindowsMongoFactbook.Models
{
    public class TerritoryType
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        IEnumerable<Territory> Territories { get; set; }

    }
}