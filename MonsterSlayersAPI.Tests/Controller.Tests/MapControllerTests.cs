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
using Microsoft.AspNetCore.Http;

namespace MonsterSlayersAPI.Tests.Controller.Tests
{
	public class MapControllerTests
	{
		/*private Position _position;
		private const string token = "token123";

		[Fact]
		public async void ShouldReturnPlayerPositionWithValidToken()
		{
			string UserId = "test";

			IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();

			_position = new Position()
			{
				UserId = UserId,
				UnlockedZones = new[] { 100 },
				Xpos = 20,
				Ypos = 0,
				ZoneId = 1001
			};

			var mockAuthService = new Mock<IAuthService>();
			var mockMapService = new Mock<IMapService>();
			var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

			mockAuthService.Setup(a => a.GetTokenFromHttpContext(httpContextAccessor.HttpContext)).Returns("token123");
			mockAuthService.Setup(a => a.GetPlayerUserId(token)).ReturnsAsync(UserId);
			mockMapService.Setup(m => m.GetPlayerPosition(UserId)).ReturnsAsync(_position);

			var controller = new MapController(mockAuthService.Object, mockMapService.Object, mockHttpContextAccessor.Object);

			var result = await controller.GetPlayerPosition() as ObjectResult;
			var actualResult = result.Value;

			Assert.IsType<OkObjectResult>(result);
			Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result.StatusCode);
			Assert.Equal(_position.UserId, ((Position)actualResult).UserId);
			Assert.Equal(_position.UnlockedZones, ((Position)actualResult).UnlockedZones);
			Assert.Equal(_position.Xpos, ((Position)actualResult).Xpos);
			Assert.Equal(_position.Ypos, ((Position)actualResult).Ypos);
			Assert.Equal(_position.ZoneId, ((Position)actualResult).ZoneId);
		}

		[Fact]
		public async void ShouldUpdatePlayerPositionWithValidModel()
		{
			string UserId = "test";

			IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();

			_position = new Position()
			{
				UserId = UserId,
				UnlockedZones = new[] { 100 },
				Xpos = 20,
				Ypos = 0,
				ZoneId = 1001
			};

			var mockAuthService = new Mock<IAuthService>();
			var mockMapService = new Mock<IMapService>();
			var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

			mockAuthService.Setup(a => a.GetTokenFromHttpContext(httpContextAccessor.HttpContext)).Returns("token123");
			mockAuthService.Setup(a => a.GetPlayerUserId(token)).ReturnsAsync(UserId);
			mockMapService.Setup(m => m.GetPlayerPosition(UserId)).ReturnsAsync(_position);

			var controller = new MapController(mockAuthService.Object, mockMapService.Object, mockHttpContextAccessor.Object);

			var result = await controller.UpdatePlayerPosition(_position) as StatusCodeResult;

			Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);

		}

		[Fact]
		public async void ShouldReturnBadRequestWithEmptyModel()
		{
			string UserId = "test";

			IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();

			var mockAuthService = new Mock<IAuthService>();
			var mockMapService = new Mock<IMapService>();
			var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

			mockAuthService.Setup(a => a.GetTokenFromHttpContext(httpContextAccessor.HttpContext)).Returns("token123");
			mockAuthService.Setup(a => a.GetPlayerUserId(token)).ReturnsAsync(UserId);
			mockMapService.Setup(m => m.GetPlayerPosition(UserId)).ReturnsAsync(_position);

			var controller = new MapController(mockAuthService.Object, mockMapService.Object, mockHttpContextAccessor.Object);

			var result = await controller.UpdatePlayerPosition(_position) as StatusCodeResult;

			Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
		}*/

	}
}
