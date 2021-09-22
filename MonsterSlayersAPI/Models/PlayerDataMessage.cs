using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Models
{
	public class PlayerDataMessage
	{		
		public string UserId { get; set; }
		public Player Player { get; set; }
		public PlayerStats PlayerStats { get; set; }
		public Position Position { get; set; }
		public Inventory Inventory { get; set; }
	}
}
