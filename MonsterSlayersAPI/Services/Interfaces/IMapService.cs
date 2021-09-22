using MonsterSlayersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Services.Interfaces
{
	public interface IMapService
	{
		Task<Position> GetPlayerPosition(string UserId);
		Task InsertPlayerPosition(Position position);
		Task UpdatePlayerPosition(Position position);
		Task<Position> CreatePlayerPosition(string UserId);
		bool IsMovementAvailable(Position position);
	}
}
