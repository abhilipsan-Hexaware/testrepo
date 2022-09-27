using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnetbackend.Entities.Entities
{
    [BsonIgnoreExtraElements]
    public class Document
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id  { get; set; }
        public string Name  { get; set; }
        public string FileType  { get; set; }
        
    }

}
