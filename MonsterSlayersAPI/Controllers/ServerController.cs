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
	[Authorize]
	public class ServerController
	{
		private readonly IAuthService _authService;
		private readonly IServerService _serverService;
		
		public ServerController(IAuthService authService, IServerService serverService)
		{
			_authService = authService;
			_serverService = serverService;
		}

		[Authorize]
		[HttpGet]
		[Route("Server")]
		public async Task<ServerDTO> GetServerForPlayer(bool refresh)
		{
			return DTOFactory.CreateFrom(new Server());
		}
	}
}
