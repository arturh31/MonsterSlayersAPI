using MonsterSlayersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Services.Interfaces
{
	public interface IPlayerStatsService
	{
		Task<PlayerStats> GetPlayerStats(string UserId);
		Task UpdatePlayerStats (PlayerStats playerStats);
		Task InsertPlayerStats(PlayerStats playerStats);
		Task<PlayerStats> CreatePlayerStats(string UserId);
	}
}
