using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace WindowsMongoFactbook.Models
{
    public class GeochartLevel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Level")]
        public string Level { get; set; }

        IEnumerable<Territory> Territories { get; set; }
    }
}
