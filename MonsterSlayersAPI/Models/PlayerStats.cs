 using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MonsterSlayersAPI.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Models
{
	[BsonCollection("PlayerStats")]
	public class PlayerStats : IDocument
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
		public string UserId { get; set; }
		public int Level { get; set; }
		public int Experience { get; set; }
		public int Strength { get; set; }
		public int Intellect { get; set; }
		public int Agility { get; set; }
		public int Vitality { get; set; }
	}
}
