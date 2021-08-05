using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AngularApp.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName {  get; set; }
        public string Email { get; set; }
        [BsonDateTimeOptions]
        public DateTime Created { get; set; } = default(DateTime);
        [BsonDateTimeOptions]
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }

    }
}
