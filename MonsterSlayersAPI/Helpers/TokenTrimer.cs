using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Helpers
{
	public class TokenTrimer
	{
		public string TrimToken(string token)
		{
			token = token.Split(' ')[1];

			return token;
		}
	}
}
