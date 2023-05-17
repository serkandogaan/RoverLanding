using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.Entity.Concrete
{
    public class BaseClass
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId, BsonElement("_id")]
        public ObjectId Id { get; set; }
        public int ID;
        public string Name { get; set; }
    }
}
