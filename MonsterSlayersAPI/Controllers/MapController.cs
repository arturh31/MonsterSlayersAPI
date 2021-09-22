using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonsterSlayersAPI.Models;
using MonsterSlayersAPI.Services.Interfaces;
using MonsterSlayersAPI.SharedDefinitions.DTO;

namespace MonsterSlayersAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MapController
	{
		private readonly IAuthService _authService;
		private readonly IMapService _mapService;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public MapController(IAuthService authService, IMapService mapService, IHttpContextAccessor httpContextAccessor)
		{
			_authService = authService;
			_mapService = mapService;
			_httpContextAccessor = httpContextAccessor;
		}

		[HttpGet]
		[Authorize]
		[Route("PlayerPosition")]
		public async Task<PositionDTO> GetPlayerPosition()
		{
			var token = _authService.GetTokenFromHttpContext(_httpContextAccessor.HttpContext);
			var UserId = await _authService.GetPlayerUserId(token);
			var position = await _mapService.GetPlayerPosition(UserId);

			return DTOFactory.CreateFrom(position);
		}

		[HttpPost]
		[Authorize]
		[Route("PlayerPosition")]
		public async Task<bool> UpdatePlayerPosition([FromBody] Position position)
		{
			var token = _authService.GetTokenFromHttpContext(_httpContextAccessor.HttpContext);
			var UserId = await _authService.GetPlayerUserId(token);

			if (position != null)
			{
				position.UserId = UserId;
				await _mapService.UpdatePlayerPosition(position);
				return true;
			}
			return false;
		}

		[HttpGet]
		[Authorize]
		[Route("Movement")]
		public async Task<bool> IsMovementPossible([FromBody] Position position)
		{
			var token = _authService.GetTokenFromHttpContext(_httpContextAccessor.HttpContext);
			var UserId = await _authService.GetPlayerUserId(token);
			position.UserId = UserId;

			var isPossible = _mapService.IsMovementAvailable(position);

			return isPossible;
		}
	}
}
	