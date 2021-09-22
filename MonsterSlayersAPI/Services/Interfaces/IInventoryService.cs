using MonsterSlayersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Services.Interfaces
{
	public interface IInventoryService
	{
		Task<Inventory> CreatePlayerInventory(string UserId);
		Task<Inventory> GetPlayerInventory(string UserId);
		Task UpdatePlayerInventory(Inventory inventory);
		Task InsertInventory(Inventory inventory);

	}
}
