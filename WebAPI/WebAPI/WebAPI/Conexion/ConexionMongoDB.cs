using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core.Servers;
using System.Threading.Tasks;
namespace WebApplication3.Conexiones
{
    // <summary>
    /// Descripción breve de ConexionMongo
    /// </summary>
    public class ConexionMongoDB
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;


        public ConexionMongoDB()
        {
            try
            {
                _client = new MongoClient();
                _database = _client.GetDatabase("Base1Mongo");
                /* MongoUrl url = new MongoUrl("mongodb://localhost:27017");
                 MongoClient mongoDB = new MongoClient(url);

                 mongoDB.GetDatabase("Base1Mongo");*/

            }
            catch (Exception ex)
            {

            }
        }

        public void CrearMongoDB(string database_name)
        {
            try
            {
                _client = new MongoClient();
                _database = _client.GetDatabase(database_name);
                ConexionMariaDBMeta con = new ConexionMariaDBMeta();
                con.InsertarMongo(database_name);


            }
            catch (Exception ex)
            {

            }
        }

        public void Insertar()
        {
            var document = new BsonDocument
{
    { "address" , new BsonDocument
        {
            { "street", "2 Avenue" },
            { "zipcode", "10075" },
            { "building", "1480" },
            { "coord", new BsonArray { 73.9557413, 40.7720266 } }
        }
    },
    { "borough", "Manhattan" },
    { "cuisine", "Italian" },
    { "grades", new BsonArray
        {
            new BsonDocument
            {
                { "date", new DateTime(2014, 10, 1, 0, 0, 0, DateTimeKind.Utc) },
                { "grade", "A" },
                { "score", 11 }
            },
            new BsonDocument
            {
                { "date", new DateTime(2014, 1, 6, 0, 0, 0, DateTimeKind.Utc) },
                { "grade", "B" },
                { "score", 17 }
            }
        }
    },
    { "name", "Vella" },
    { "restaurant_id", "41704620" }
};

            var collection = _database.GetCollection<BsonDocument>("resti");
            collection.InsertOneAsync(document);


        }


    }
}