using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonsterSlayersAPI.Models;
using MonsterSlayersAPI.Services;
using MonsterSlayersAPI.Services.Interfaces;

namespace MonsterSlayersAPI.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class PlayerDataController
	{
		private readonly IPlayerService _playerService;
		private readonly IAuthService _authService;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public PlayerDataController(IPlayerService playerService, IAuthService authService, IHttpContextAccessor httpContextAccessor)
		{
			_playerService = playerService;
			_authService = authService;
			_httpContextAccessor = httpContextAccessor;
		}

		[HttpGet]
		[Authorize]
		[Route("PlayerData")]
		public async Task<PlayerDataMessage> GetPlayerData()
		{
			var token = _authService.GetTokenFromHttpContext(_httpContextAccessor.HttpContext);
			var UserId = await _authService.GetPlayerUserId(token);
			var result = await _playerService.GetPlayerDataByUserId(UserId);

			return result;
		}

		[HttpPost]
		[Authorize]
		[Route("PlayerName")]
		public async Task<bool> SetPlayerName(string name)
		{
			var token = _authService.GetTokenFromHttpContext(_httpContextAccessor.HttpContext);
			var UserId = await _authService.GetPlayerUserId(token);

			try
			{
				await _playerService.UpdatePlayerName(UserId, name);
				return true;
			}
			catch (Exception ex)
			{
				throw ex;			
			}
		}

	}
}
