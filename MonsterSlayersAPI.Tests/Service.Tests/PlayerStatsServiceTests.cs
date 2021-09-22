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
	public class PlayerStatsServiceTests
	{
		/*private PlayerStats _playerStats;
		string UserId = "test";

		[Fact]
		public async void ShouldReturnPlayerStats()
		{
			_playerStats = new PlayerStats
			{
				UserId = UserId,
				Agility = 5,
				Experience = 0,
				Intellect = 5,
				Level = 1,
				Strength = 5,
				Vitality = 5
			};

			var mockMongoRepository = new Mock<IMongoRepository<PlayerStats>>();
			mockMongoRepository.Setup(r => r.GetByUserIdAsync(UserId)).ReturnsAsync(_playerStats);

			var service = new PlayerStatsService(mockMongoRepository.Object);
			var result = await service.GetPlayerStats(UserId);

			mockMongoRepository.Verify(m => m.GetByUserIdAsync(UserId), Times.Once);
			Assert.Equal(result, _playerStats);
		}

		[Fact]
		public async void ShouldThrowExceptionOnUpdateWithNullPlayerStats()
		{
			_playerStats = null;

			var mockMongoRepository = new Mock<IMongoRepository<PlayerStats>>();
			mockMongoRepository.Setup(i => i.UpdateOneAsync(_playerStats)).Throws<ArgumentNullException>();

			var service = new PlayerStatsService(mockMongoRepository.Object);

			await Assert.ThrowsAsync<ArgumentNullException>(() => service.UpdatePlayerStats(_playerStats));

		}*/
	}
}
