using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MonsterSlayersAPI.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Models
{
	[BsonCollection("Server")]
	public class Server : IDocument
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
		public string UserId { get; set; }
		public string Ip { get; set; }
		public int Port { get; set; }
		public string GameSessionToken { get; set; }
	}
}
