using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Helpers
{
	public class PlayerNameGenerator
	{
		public string GeneratePlayerName() 
		{ 
			var name = "player" + new Random().Next(1000000, 9999999).ToString();
			return name;
		}

	}
}
