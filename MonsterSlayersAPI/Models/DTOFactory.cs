using MonsterSlayersAPI.SharedDefinitions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MonsterSlayersAPI.Models
{
	public class DTOFactory
	{
		public static InventoryDTO CreateFrom(Inventory inventory)
		{
			return new InventoryDTO()
			{
				UserId = inventory.UserId,
				BagItems = inventory.BagItems,
				Currency = inventory.Currency,
				Equipped = inventory.Equipped
			};
		}

		public static PlayerDTO CreateFrom(Player player)
		{
			return new PlayerDTO()
			{
				Name = player.Name,
				UserId = player.UserId
			};
		}

		public static PlayerStatsDTO CreateFrom(PlayerStats playerStats)
		{
			return new PlayerStatsDTO()
			{
				UserId = playerStats.UserId,
				Experience = playerStats.Experience,
				Level = playerStats.Level,
				Agility = playerStats.Agility,
				Intellect = playerStats.Intellect,
				Strength = playerStats.Strength,
				Vitality = playerStats.Vitality			
			};
		}

		public static PositionDTO CreateFrom(Position position)
		{
			return new PositionDTO()
			{
				UserId = position.UserId,
				UnlockedZones = position.UnlockedZones,
				Xpos = position.Xpos,
				Ypos = position.Ypos,
				ZoneId = position.ZoneId
			};
		}

		public static ServerDTO CreateFrom(Server server)
		{
			return new ServerDTO()
			{
				UserId = server.UserId,
				Ip = server.Ip,
				Port = server.Port,
				GameSessionToken = server.GameSessionToken
			};
		}

	}
}
