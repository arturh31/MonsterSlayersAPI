using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonsterSlayersAPI.Helpers;
using MonsterSlayersAPI.Models;
using MonsterSlayersAPI.Repository;
using MonsterSlayersAPI.Services.Interfaces;
using MonsterSlayersAPI.SharedDefinitions.DTO;

namespace MonsterSlayersAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InventoryController
	{
		private readonly IAuthService _authService;
		private readonly IInventoryService _inventoryService;
		private readonly IHttpContextAccessor _httpContextAccessor;
		

		public InventoryController(IAuthService authService, IInventoryService inventoryService, IHttpContextAccessor httpContextAccessor)
		{
			_authService = authService;
			_inventoryService = inventoryService;
			_httpContextAccessor = httpContextAccessor;
		}

		[HttpGet]
		[Authorize]
		[Route("PlayerInventory")]
		public async Task<InventoryDTO> GetPlayerInventory()
		{
			var token = _authService.GetTokenFromHttpContext(_httpContextAccessor.HttpContext);
			var UserId = await _authService.GetPlayerUserId(token);
			var inventory = await _inventoryService.GetPlayerInventory(UserId);	

			return DTOFactory.CreateFrom(inventory); 
		}
		[HttpPost]
		[Authorize]
		[Route("PlayerInventory")]
		public async Task<bool> UpdatePlayerInventory([FromBody] Inventory inventory)
		{	
			var token = _authService.GetTokenFromHttpContext(_httpContextAccessor.HttpContext);
			var UserId = await _authService.GetPlayerUserId(token);

			if (inventory != null)
			{
				inventory.UserId = UserId;
				await _inventoryService.UpdatePlayerInventory(inventory);
				return true;
			}		

			return false;
		}

	}
}
