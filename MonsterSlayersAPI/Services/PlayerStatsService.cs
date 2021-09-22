using MongoDB.Driver;
using MonsterSlayersAPI.Models;
using MonsterSlayersAPI.Repository;
using MonsterSlayersAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Services
{
	public class PlayerStatsService : IPlayerStatsService
	{
		
		private readonly IMongoRepository<PlayerStats> _playerStatsRepository;

		public PlayerStatsService(IMongoRepository<PlayerStats> playerStatsRepository)
		{ 
			_playerStatsRepository = playerStatsRepository;
		}

		public async Task<PlayerStats> GetPlayerStats(string UserId)
		{
			var result = await _playerStatsRepository.GetByUserIdAsync(UserId);
			return result;
		}

		public async Task UpdatePlayerStats(PlayerStats playerStats) => await _playerStatsRepository.UpdateOneAsync(playerStats);

		public async Task InsertPlayerStats(PlayerStats playerStats)
		{
			await _playerStatsRepository.CreateOneAsync(playerStats);
		}

		public async Task<PlayerStats> CreatePlayerStats(string UserId)
		{
			var existingPlayerStats = await GetPlayerStats(UserId);
			var newPlayerStats = new PlayerStats { UserId = UserId, Agility = 5, Experience = 0, Intellect = 5, Level = 1, Strength = 5, Vitality = 5 };

			if (existingPlayerStats == null)
			{
				return newPlayerStats;
			}
			else
			{
				await _playerStatsRepository.DeleteOneAsync(UserId);
				return newPlayerStats;
			}
		}
	}
}
