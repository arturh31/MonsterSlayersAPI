using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MonsterSlayersAPI.Models.Data;

namespace MonsterSlayersAPI.Models
{
	[BsonCollection("Player")]
	public class Player : IDocument
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }	
		public string UserId { get; set; }
		public string Name { get; set; }

	}
}
