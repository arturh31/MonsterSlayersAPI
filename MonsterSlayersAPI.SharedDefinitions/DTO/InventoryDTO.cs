using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterSlayersAPI.SharedDefinitions.DTO
{
	public class InventoryDTO
	{
		public string UserId { get; set; }
		public double Currency { get; set; }
		public int[] Equipped { get; set; }
		public int[] BagItems { get; set; }

	}
}
