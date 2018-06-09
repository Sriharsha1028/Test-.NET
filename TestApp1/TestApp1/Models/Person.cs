using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace TestApp1.Models
{
    public class Person
    {
        [BsonId]
        public Guid? PersonId { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int height { get; set; }
    }
}