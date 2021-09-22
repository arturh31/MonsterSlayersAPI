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
	public class InventoryControllerTests
	{
		/*private Inventory _inventory;
		private const string token = "token token";

		[Fact]
		public async void ShouldReturnInventoryWithValidToken()
		{
			string UserId = "test";
			IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();

			_inventory = new Inventory()
			{
				UserId = "test",
				BagItems = new[] { 1001, 1002, 1003 },
				Currency = 100,
				Equipped = new[] { 2001, 2002, 2003, 2004, 2005 }
			};

			var mockAuthService = new Mock<IAuthService>();
			var mockInventoryService = new Mock<IInventoryService>();
			var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

			mockAuthService.Setup(a => a.GetTokenFromHttpContext(httpContextAccessor.HttpContext)).Returns("token token");
			mockAuthService.Setup(a => a.GetPlayerUserId(token)).ReturnsAsync(UserId);
			mockInventoryService.Setup(i => i.GetPlayerInventory(UserId)).ReturnsAsync(_inventory);

			var controller = new InventoryController(mockAuthService.Object, mockInventoryService.Object, mockHttpContextAccessor.Object);

			var result = await controller.GetPlayerInventory();
			var actualResult = result;

			Assert.IsType<OkObjectResult>(result);
			//Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result.StatusCode);
			Assert.Equal(_inventory.UserId, ((Inventory)actualResult).UserId);
			Assert.Equal(_inventory.BagItems, ((Inventory)actualResult).BagItems);
			Assert.Equal(_inventory.Currency, ((Inventory)actualResult).Currency);
			Assert.Equal(_inventory.Equipped, ((Inventory)actualResult).Equipped);
			Assert.Equal(_inventory.Id, ((Inventory)actualResult).Id);
		}

		[Fact]
		public async void ShouldUpdateInventoryWithValidModel()
		{
			string UserId = "test";
			IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();

			_inventory = new Inventory()
			{
				UserId = "test",
				BagItems = new[] { 1001, 1002, 1003 },
				Currency = 100,
				Equipped = new[] { 2001, 2002, 2003, 2004, 2005 }
			};

			var mockAuthService = new Mock<IAuthService>();
			var mockInventoryService = new Mock<IInventoryService>();
			var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

			mockAuthService.Setup(a => a.GetTokenFromHttpContext(httpContextAccessor.HttpContext)).Returns("token token");
			mockAuthService.Setup(a => a.GetPlayerUserId(token)).ReturnsAsync(UserId);
			mockInventoryService.Setup(i => i.GetPlayerInventory(UserId)).ReturnsAsync(_inventory);

			var controller = new InventoryController(mockAuthService.Object, mockInventoryService.Object, mockHttpContextAccessor.Object);		

			var result = await controller.UpdatePlayerInventory(_inventory) as StatusCodeResult;		

			Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);


		}

		[Fact]
		public async void ShouldReturnBadRequestWithEmptyModel()
		{
			string UserId = "test";

			IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
		
			var mockAuthService = new Mock<IAuthService>();
			var mockInventoryService = new Mock<IInventoryService>();
			var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

			mockAuthService.Setup(a => a.GetTokenFromHttpContext(httpContextAccessor.HttpContext)).Returns("token token");
			mockAuthService.Setup(a => a.GetPlayerUserId(token)).ReturnsAsync(UserId);
			mockInventoryService.Setup(i => i.GetPlayerInventory(UserId)).ReturnsAsync(_inventory);

			var controller = new InventoryController(mockAuthService.Object, mockInventoryService.Object, mockHttpContextAccessor.Object);

			var result = await controller.UpdatePlayerInventory(_inventory) as StatusCodeResult;

			Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
		}*/
	}
}
