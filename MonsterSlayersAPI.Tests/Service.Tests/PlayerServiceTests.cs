using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using MonsterSlayersAPI.Repository;
using MonsterSlayersAPI.Models;
using MonsterSlayersAPI.Services.Interfaces;
using MonsterSlayersAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using MonsterSlayersAPI.Services;

namespace MonsterSlayersAPI.Tests.Service.Tests
{
	public class PlayerServiceTests
	{
		/*private Player _player;

		[Fact]
		public async void ShouldReturnPlayer()
		{
			string UserId = "test";
			_player = new Player
			{
				UserId = UserId,
				Name = "player999999999"
			};
			
			
			var mockMongoRepository = new Mock<IMongoRepository<Player>>();
			var mockInventoryService = new Mock<IInventoryService>();
			var mockMapService = new Mock<IMapService>();
			var mockPlayerStatsService = new Mock<IPlayerStatsService>();
			

			mockMongoRepository.Setup(r => r.GetByUserIdAsync(UserId)).ReturnsAsync(_player);

			var service = new PlayerService(mockInventoryService.Object, mockMapService.Object, mockPlayerStatsService.Object, mockMongoRepository.Object);
			var result = await service.GetPlayerByUserId(UserId);

			mockMongoRepository.Verify(m => m.GetByUserIdAsync(UserId), Times.Once);
			Assert.Equal(result, _player);
		}

		[Fact]
		public async void ShouldThrowExceptionOnUpdateWithNullPlayer()
		{
			_player = null;

			var mockMongoRepository = new Mock<IMongoRepository<Player>>();
			var mockInventoryService = new Mock<IInventoryService>();
			var mockMapService = new Mock<IMapService>();
			var mockPlayerStatsService = new Mock<IPlayerStatsService>();

			mockMongoRepository.Setup(i => i.UpdateOneAsync(_player)).Throws<ArgumentNullException>();

			var service = new PlayerService(mockInventoryService.Object, mockMapService.Object, mockPlayerStatsService.Object, mockMongoRepository.Object);

			await Assert.ThrowsAsync<ArgumentNullException>(() => service.UpdatePlayer(_player));

		}

		[Fact]
		public async void ShouldUpdatePlayerName()
		{
			string UserId = "test";
			string name = "player111111111";
			_player = new Player
			{
				UserId = UserId,
				Name = "player999999999"
			};

			Player _updatedPlayer;
			
			var mockMongoRepository = new Mock<IMongoRepository<Player>>();
			var mockInventoryService = new Mock<IInventoryService>();
			var mockMapService = new Mock<IMapService>();
			var mockPlayerStatsService = new Mock<IPlayerStatsService>();
			var mockPlayerService = new Mock<IPlayerService>();

			mockMongoRepository.Setup(m => m.GetByUserIdAsync(UserId)).ReturnsAsync(_player);
			mockPlayerService.Setup(p => p.GetPlayerByUserId(UserId)).ReturnsAsync(_player);
			mockMongoRepository.Setup(m => m.GetByNameAsync(name)).ReturnsAsync((Player)null);
			mockMongoRepository.Setup(m => m.UpdateOneAsync(_player));
			_updatedPlayer = _player;

			var service = new PlayerService(mockInventoryService.Object, mockMapService.Object, mockPlayerStatsService.Object, mockMongoRepository.Object);

			await service.UpdatePlayerName(UserId, name);

			mockMongoRepository.Verify(m => m.GetByNameAsync(name), Times.Once);
			mockMongoRepository.Verify(m => m.UpdateOneAsync(_player), Times.Once);

			Assert.Equal(_player.Name, name);

		}

		[Fact]
		public async void ShouldThrowExceptionOnDuplicateName()
		{
			string UserId = "test";
			string name = "player111111111";
			_player = new Player
			{
				UserId = UserId,
				Name = "player111111111"
			};

			Player _updatedPlayer;

			var mockMongoRepository = new Mock<IMongoRepository<Player>>();
			var mockInventoryService = new Mock<IInventoryService>();
			var mockMapService = new Mock<IMapService>();
			var mockPlayerStatsService = new Mock<IPlayerStatsService>();
			var mockPlayerService = new Mock<IPlayerService>();

			mockMongoRepository.Setup(m => m.GetByUserIdAsync(UserId)).ReturnsAsync(_player);
			mockPlayerService.Setup(p => p.GetPlayerByUserId(UserId)).ReturnsAsync(_player);
			mockMongoRepository.Setup(m => m.GetByNameAsync(name)).ReturnsAsync(_player);
			mockMongoRepository.Setup(m => m.UpdateOneAsync(_player));
			_updatedPlayer = _player;

			var service = new PlayerService(mockInventoryService.Object, mockMapService.Object, mockPlayerStatsService.Object, mockMongoRepository.Object);

			await Assert.ThrowsAsync<Exception>(() => service.UpdatePlayerName(UserId, name));

		}*/
	}
}
