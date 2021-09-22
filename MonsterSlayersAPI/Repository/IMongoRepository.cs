using MonsterSlayersAPI.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Repository
{
	public interface IMongoRepository<TDocument> where TDocument : IDocument
	{
		public Task<TDocument> GetByUserIdAsync(string UserId);
		Task<TDocument> GetByNameAsync(string name);
		public Task UpdateOneAsync(TDocument obj);
		public Task CreateOneAsync(TDocument obj);
		public Task DeleteOneAsync(string UserId);
	}
}
