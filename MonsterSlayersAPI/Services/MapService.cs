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
	public class MapService : IMapService
	{		
		
		private readonly IMongoRepository<Position> _positionRepository;
	
		public MapService(IMongoRepository<Position> positionRepository)
		{
			_positionRepository = positionRepository;			
		}

		public async Task<Position> GetPlayerPosition(string UserId)
		{
			var result = await _positionRepository.GetByUserIdAsync(UserId);
			return result;
		}

		public async Task InsertPlayerPosition(Position position)
		{
			await _positionRepository.CreateOneAsync(position);
		}

		public async Task UpdatePlayerPosition(Position position) => await _positionRepository.UpdateOneAsync(position);

		public async Task<Position> CreatePlayerPosition(string UserId)
		{
			var existingPosition = await GetPlayerPosition(UserId);
			var newPosition = new Position { UserId = UserId, UnlockedZones = new[] { 100 }, Xpos = 20, Ypos = 0, ZoneId = 1001 };

			if (existingPosition == null)
			{
				return newPosition;
			}
			else
			{
				await _positionRepository.DeleteOneAsync(UserId);
				return newPosition;
			}
		}

		//TODO: Implement logic here. It will check movement possibility.
		public bool IsMovementAvailable(Position position)
		{
			return true;
		}
	}
}
