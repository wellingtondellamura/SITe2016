using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMongoClient client = new MongoClient();
            IMongoDatabase db = client.GetDatabase("treinamento");
            var contato = db.GetCollection<BsonDocument>("contato");
            var filter = new BsonDocument();
            var lst = contato.Find<BsonDocument>(filter);
            lst.ForEachAsync(e =>
            {
                e.Names.ToList().ForEach(ee => Console.WriteLine(ee));
                e.ToList().ForEach(l => Console.WriteLine(l));
            });
            Console.ReadKey();
        }
    }
}
