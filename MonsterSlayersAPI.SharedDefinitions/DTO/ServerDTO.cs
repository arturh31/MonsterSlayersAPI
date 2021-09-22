using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterSlayersAPI.SharedDefinitions.DTO
{
	public class ServerDTO
	{
		public string UserId { get; set; }
		public string Ip { get; set; }
		public int Port { get; set; }
		public string GameSessionToken { get; set; }
	}
}
