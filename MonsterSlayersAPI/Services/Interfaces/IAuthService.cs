using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Services.Interfaces
{
	public interface IAuthService
	{
		Task<string> GetPlayerUserId(string token);
		string GetTokenFromHttpContext(HttpContext httpContext);
	}
}
