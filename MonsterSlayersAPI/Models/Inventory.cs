using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MonsterSlayersAPI.Models.Data;

namespace MonsterSlayersAPI.Models
{
	[BsonCollection("Inventory")]
	public class Inventory : IDocument
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
		public string UserId { get; set; }
		public double Currency { get; set; }
		public int[] Equipped { get; set; }
		public int[] BagItems { get; set; }
	}
}
