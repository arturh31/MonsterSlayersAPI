using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MonsterSlayersAPI.Models;
using MonsterSlayersAPI.Services.Interfaces;
using MonsterSlayersAPI.Helpers;
using MonsterSlayersAPI.Repository;

namespace MonsterSlayersAPI.Services
{
	public class PlayerService : IPlayerService
	{
		private readonly IMongoRepository<Player> _playerRepository;
	
		private readonly IInventoryService _inventoryService;
		private readonly IMapService _mapService;
		private readonly IPlayerStatsService _playerStatsService;

		//private Player _player;

		public PlayerService(IInventoryService inventoryService, IMapService mapService, IPlayerStatsService playerStatsService, IMongoRepository<Player> playerRepository)
		{			
			_inventoryService = inventoryService;
			_mapService = mapService;
			_playerStatsService = playerStatsService;
			_playerRepository = playerRepository;
	
		}

		//Hardcoded new player data. In the future it will be moved to database.
		public async Task<PlayerDataMessage> GetPlayerDataByUserId(string UserId)
		{
			var player = await _playerRepository.GetByUserIdAsync(UserId);
			var inventory = await _inventoryService.GetPlayerInventory(UserId);
			var position = await _mapService.GetPlayerPosition(UserId);
			var playerStats = await _playerStatsService.GetPlayerStats(UserId);

			var result = new PlayerDataMessage
			{
				UserId = UserId,
				Player = player,
				Inventory = inventory,
				Position = position,
				PlayerStats = playerStats,
			};
			
			if (result.Player == null)
			{

				result = await CreatePlayer(new PlayerDataMessage
				{
					UserId = UserId,
					Player = new Player { UserId = UserId, Name = new PlayerNameGenerator().GeneratePlayerName() },
					PlayerStats = _playerStatsService.CreatePlayerStats(UserId).Result,
					Inventory = _inventoryService.CreatePlayerInventory(UserId).Result,
					Position = _mapService.CreatePlayerPosition(UserId).Result
				});
			}

			return result; 
		}

		public async Task<Player> GetPlayerByUserId(string UserId)
		{
			return await _playerRepository.GetByUserIdAsync(UserId);
		}


		public async Task UpdatePlayer(Player player)
		{
			await _playerRepository.UpdateOneAsync(player);
		}
		public async Task UpdatePlayerName(string UserId, string name)
		{			
			var player = GetPlayerByUserId(UserId).Result;

			var duplicates = await _playerRepository.GetByNameAsync(name);

			if (duplicates == null)
			{
				player.Name = name;
				player.UserId = UserId;
				await _playerRepository.UpdateOneAsync(player);				
			}
			else
			{
				throw new Exception($"Player with {name} already exists!");
			}
		}

		public async Task<PlayerDataMessage> CreatePlayer(PlayerDataMessage player)
		{	
			await _playerRepository.CreateOneAsync(player.Player);
			await _playerStatsService.InsertPlayerStats(player.PlayerStats);
			await _inventoryService.InsertInventory(player.Inventory);
			await _mapService.InsertPlayerPosition(player.Position);
			
			return player;
		}
	}
}
