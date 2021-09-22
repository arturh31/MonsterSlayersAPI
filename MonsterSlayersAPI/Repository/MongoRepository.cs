using MongoDB.Driver;
using MonsterSlayersAPI.Models;
using MonsterSlayersAPI.Models.Data;
using MonsterSlayersAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Repository
{
	public class MongoRepository<TDocument> : IMongoRepository<TDocument> where TDocument : IDocument
    { 
        private readonly IMongoCollection<TDocument> _collection;

        public MongoRepository(IPlayerDatabaseSettings settings)
        {
            var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<TDocument>(GetCollectionName(typeof(TDocument)));
        }

        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true)
                .FirstOrDefault())?.CollectionName;
        }

        public async Task<TDocument> GetByUserIdAsync(string UserId)
        {

            FilterDefinition<TDocument> filter = Builders<TDocument>.Filter.Eq("UserId", UserId);

            return await _collection.FindAsync(filter).Result.FirstOrDefaultAsync();

        }

        public async Task<TDocument> GetByNameAsync(string name)
        {
            FilterDefinition<TDocument> filter = Builders<TDocument>.Filter.Eq("Name", name);
            return await _collection.FindAsync(filter).Result.FirstOrDefaultAsync();
        }
        public async Task CreateOneAsync(TDocument obj)
        {
            if (obj == null || obj.UserId == null)
            {
                throw new ArgumentNullException(typeof(TDocument).Name + " object is null");
            }
            await _collection.InsertOneAsync(obj);
        }
        public async Task UpdateOneAsync(TDocument obj)
        {
           if(obj == null || obj.UserId == null)
		   {
              throw new ArgumentNullException(typeof(TDocument).Name + " object is null");
           }

           await _collection.ReplaceOneAsync(Builders<TDocument>.Filter.Eq("UserId", obj.UserId), obj);         
        }
        public async Task DeleteOneAsync(string UserId)
        {      
           await _collection.DeleteOneAsync(Builders<TDocument>.Filter.Eq("UserId", UserId));
        }


    }
}
