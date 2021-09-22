using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterSlayersAPI.SharedDefinitions.DTO
{
	public class PlayerStatsDTO
	{
		public string UserId { get; set; }
		public int Level { get; set; }
		public int Experience { get; set; }
		public int Strength { get; set; }
		public int Intellect { get; set; }
		public int Agility { get; set; }
		public int Vitality { get; set; }
	}
}
