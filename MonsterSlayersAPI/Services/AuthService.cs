using FirebaseAdmin.Auth;
using MonsterSlayersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterSlayersAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace MonsterSlayersAPI.Services
{
	public class AuthService : IAuthService
	{      
        public async Task<string> GetPlayerUserId(string token)
        {           
            try
            {
                FirebaseToken decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token);
                return decodedToken.Uid;
            }
            catch (FirebaseAuthException ex)
			{
                throw ex;
			}     
        }
        public string GetTokenFromHttpContext(HttpContext httpContext)
		{
            string token = httpContext.Request.Headers["Authorization"];

            return token.Split(' ')[1];
		}
    }
}
