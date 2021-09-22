using MongoDB.Driver;
using MonsterSlayersAPI.Models;
using MonsterSlayersAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterSlayersAPI.Repository;

namespace MonsterSlayersAPI.Services
{
	public class InventoryService : IInventoryService
	{
		private readonly IMongoRepository<Inventory> _inventoryRepository;
	
		public InventoryService(IMongoRepository<Inventory> inventoryRepository)
		{				
			_inventoryRepository = inventoryRepository;
		}
		public async Task<Inventory> GetPlayerInventory(string UserId)
		{
			return await _inventoryRepository.GetByUserIdAsync(UserId);		
		}
		public async Task UpdatePlayerInventory(Inventory inventory)
		{
			await _inventoryRepository.UpdateOneAsync(inventory);
		}

		public async Task InsertInventory(Inventory inventory)
		{
			await _inventoryRepository.CreateOneAsync(inventory);
		}

		public async Task<Inventory> CreatePlayerInventory(string UserId)
		{
			var existingInventory = await GetPlayerInventory(UserId);
			var newInventory = new Inventory { UserId = UserId, BagItems = new[] { 1001, 1002, 1003 }, Currency = 100, Equipped = new[] { 2001, 2002, 2003, 2004, 2005 } };

			if (existingInventory == null)
			{
				return newInventory;
			}
			else
			{
				await _inventoryRepository.DeleteOneAsync(UserId);
				return newInventory;
			}			
		}
	}
}
