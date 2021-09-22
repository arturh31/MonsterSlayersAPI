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
	public class MapServiceTests
	{
		/*private Position _position;
		string UserId = "test";

		[Fact]
		public async void ShouldReturnPosition()
		{
			_position = new Position()
			{
				UserId = UserId,
				UnlockedZones = new[] { 100 },
				Xpos = 20,
				Ypos = 0,
				ZoneId = 1001
			};

			var mockMongoRepository = new Mock<IMongoRepository<Position>>();
			mockMongoRepository.Setup(r => r.GetByUserIdAsync(UserId)).ReturnsAsync(_position);

			var service = new MapService(mockMongoRepository.Object);
			var result = await service.GetPlayerPosition(UserId);

			mockMongoRepository.Verify(m => m.GetByUserIdAsync(UserId), Times.Once);
			Assert.Equal(result, _position);
		}

		[Fact]
		public async void ShouldThrowExceptionOnUpdateWithNullPosition()
		{
			_position = null;

			var mockMongoRepository = new Mock<IMongoRepository<Position>>();
			mockMongoRepository.Setup(i => i.UpdateOneAsync(_position)).Throws<ArgumentNullException>();

			var service = new MapService(mockMongoRepository.Object);

			await Assert.ThrowsAsync<ArgumentNullException>(() => service.UpdatePlayerPosition(_position));

		}*/
	}
}

