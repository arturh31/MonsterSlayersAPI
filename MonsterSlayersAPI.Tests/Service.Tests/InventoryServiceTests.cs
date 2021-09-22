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
	
	public class InventoryServiceTests
	{
		/*private Inventory _inventory;

		[Fact]
		public async void ShouldReturnInventory()
		{
			string UserId = "test";

			_inventory = new Inventory()
			{
				UserId = "test",
				BagItems = new[] { 1001, 1002, 1003 },
				Currency = 100,
				Equipped = new[] { 2001, 2002, 2003, 2004, 2005 }
			};

			var mockMongoRepository = new Mock<IMongoRepository<Inventory>>();
			mockMongoRepository.Setup(r => r.GetByUserIdAsync(UserId)).ReturnsAsync(_inventory);

			var service = new InventoryService(mockMongoRepository.Object);
			var result = await service.GetPlayerInventory(UserId);

			mockMongoRepository.Verify(m => m.GetByUserIdAsync(UserId), Times.Once);
			Assert.Equal(result, _inventory);

		}

		[Fact]
		public async void ShouldThrowExceptionOnUpdateWithNullInventory()
		{
			_inventory = null;

			var mockMongoRepository = new Mock<IMongoRepository<Inventory>>();
			mockMongoRepository.Setup(i => i.UpdateOneAsync(_inventory)).Throws<ArgumentNullException>();

			var service = new InventoryService(mockMongoRepository.Object);
			
			await Assert.ThrowsAsync<ArgumentNullException>(() =>  service.UpdatePlayerInventory(_inventory));

		}*/
	}
}
