using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterSlayersAPI.SharedDefinitions.DTO
{
	public class PositionDTO
	{
		public string UserId { get; set; }
		public int[] UnlockedZones { get; set; }
		public int ZoneId { get; set; }
		public float Xpos { get; set; }
		public float Ypos { get; set; }
	}
}
