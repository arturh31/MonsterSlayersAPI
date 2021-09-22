using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MonsterSlayersAPI.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Models
{
	[BsonCollection("Position")]
	public class Position : IDocument
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
		public string UserId { get; set; }
		public int[] UnlockedZones { get; set; }
		public int ZoneId { get; set; }
		public float Xpos { get; set; }
		public float Ypos { get; set; }

	}
}
