using MonsterSlayersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Services.Interfaces
{
	public interface IPlayerService
	{
		Task<Player> GetPlayerByUserId(string UserId);
		Task<PlayerDataMessage> GetPlayerDataByUserId(string UserId);
		//Task<PlayerDataMessage> CreatePlayer(PlayerDataMessage player);
		Task UpdatePlayer(Player player);
		Task UpdatePlayerName(string UserId, string name);
	}
}
