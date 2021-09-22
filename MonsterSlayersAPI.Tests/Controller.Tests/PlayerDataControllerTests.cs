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
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MonsterSlayersAPI.Tests.Controller.Tests
{
	public class PlayerDataControllerTests
	{
		/*private PlayerDataMessage _playerData;
		private Player _player;
		const string token = "token123";

		[Fact]
		public async void ShouldReturnPlayerDataWithValidToken()
		{
			string UserId = "test";

			IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();

			_playerData = new PlayerDataMessage
			{
				UserId =  UserId,
				Inventory = new Inventory { UserId = UserId, BagItems = new[] { 1001, 1002, 1003 }, Currency = 100, Equipped = new[] { 2001, 2002, 2003, 2004, 2005 } },
				Position = new Position { UserId = UserId, UnlockedZones = new[] { 100 }, Xpos = 20, Ypos = 0, ZoneId = 1001 },
				Player = new Player { UserId = UserId, Name = "player999999999" },
				PlayerStats = new PlayerStats { UserId = UserId, Agility = 5, Experience = 0, Intellect = 5, Level = 1, Strength = 5, Vitality = 5 },
			};

			var mockAuthService = new Mock<IAuthService>();
			var mockPlayerService = new Mock<IPlayerService>();
			var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

			mockAuthService.Setup(a => a.GetTokenFromHttpContext(httpContextAccessor.HttpContext)).Returns("token123");
			mockAuthService.Setup(a => a.GetPlayerUserId(token)).ReturnsAsync(UserId);
			mockPlayerService.Setup(m => m.GetPlayerDataByUserId(UserId)).ReturnsAsync(_playerData);
			
			var controller = new PlayerDataController(mockPlayerService.Object, mockAuthService.Object, mockHttpContextAccessor.Object);

			var result = await controller.GetPlayerData() as ObjectResult;
			var actualResult = result.Value;

			Assert.IsType<OkObjectResult>(result);
			Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result.StatusCode);
			Assert.Equal(_playerData.UserId, ((PlayerDataMessage)actualResult).UserId);
			Assert.Equal(_playerData.Player, ((PlayerDataMessage)actualResult).Player);
			Assert.Equal(_playerData.Inventory, ((PlayerDataMessage)actualResult).Inventory);
			Assert.Equal(_playerData.PlayerStats, ((PlayerDataMessage)actualResult).PlayerStats);
			Assert.Equal(_playerData.Position, ((PlayerDataMessage)actualResult).Position);

		}
		[Fact]
		public async void ShouldUpdatePlayerNameWithValidModel()
		{
			string UserId = "test";
			string name = "testPlayerName";

			IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();

			_player = new Player()
			{
				UserId = UserId,
				Name = "player999999999"
			};

			var mockAuthService = new Mock<IAuthService>();
			var mockPlayerService = new Mock<IPlayerService>();
			var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

			mockAuthService.Setup(a => a.GetTokenFromHttpContext(httpContextAccessor.HttpContext)).Returns("token123");
			mockAuthService.Setup(a => a.GetPlayerUserId(token)).ReturnsAsync(UserId);
			mockPlayerService.Setup(m => m.UpdatePlayerName(UserId, name)).Returns(Task.CompletedTask);

			var controller = new PlayerDataController(mockPlayerService.Object, mockAuthService.Object, mockHttpContextAccessor.Object);

			var result = await controller.SetPlayerName(name) as StatusCodeResult;

			Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);		

		}*/
	}
}
