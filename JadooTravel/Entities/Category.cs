using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace JadooTravel.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public bool Status { get; set; }
    }
}
