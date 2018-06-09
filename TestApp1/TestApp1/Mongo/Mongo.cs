using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using TestApp1.Models;

namespace TestApp1.Mongos
{
    public class Mongo : IMongo
    {
        private IMongoCollection<Person> collection;

        public Mongo()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Test");
            collection = database.GetCollection<Person>("person");
        }

        public void CreatePerson(Person person)
        {
            person.PersonId = Guid.NewGuid();
            collection.InsertOne(person);
        }

        public void DeletePerson(string id)
        {
            var filter = Builders<Person>.Filter.Eq("PersonId", id);
            var result = collection.DeleteOne(filter);
            
        }


    }
}