using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MonsterSlayersAPI.Models;
using MonsterSlayersAPI.Repository;
using MonsterSlayersAPI.Services;
using MonsterSlayersAPI.Services.Interfaces;

namespace MonsterSlayersAPI
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;

			FirebaseApp.Create(new AppOptions()
			{
				Credential = GoogleCredential.FromFile("key.json"),
			});
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services
			   .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
			   .AddJwtBearer(options =>
			   {
				   options.Authority = "";
				   options.TokenValidationParameters = new TokenValidationParameters
				   {
					   ValidateIssuer = true,
					   ValidIssuer = "",
					   ValidateAudience = true,
					   ValidAudience = "",
					   ValidateLifetime = true
				   };
			   });

			services.Configure<PlayerDatabaseSettings>(
				Configuration.GetSection(nameof(PlayerDatabaseSettings)));

			services.AddSingleton<IPlayerDatabaseSettings>(sp =>
				sp.GetRequiredService<IOptions<PlayerDatabaseSettings>>().Value);
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

			services.AddTransient<IPlayerService, PlayerService>();
			services.AddTransient<IAuthService, AuthService>();
			services.AddTransient<IMapService, MapService>();
			services.AddTransient<IInventoryService, InventoryService>();
			services.AddTransient<IPlayerStatsService, PlayerStatsService>();
			services.AddTransient<IServerService, ServerService>();

			services.AddTransient(typeof(IMongoRepository<>), typeof(MongoRepository<>));


			services.AddControllers();

		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthentication();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
