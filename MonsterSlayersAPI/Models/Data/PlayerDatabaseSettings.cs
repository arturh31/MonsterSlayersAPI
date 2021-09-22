using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Models
{
	public class PlayerDatabaseSettings : IPlayerDatabaseSettings
	{
		public string PlayerCollectionName { get; set; }
		public string InventoryCollectionName { get; set; }
		public string NewPlayerDataCollectionName { get; set; }
		public string PlayerStatsCollectionName { get; set; }
		public string PositionCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface IPlayerDatabaseSettings
	{
		public string PlayerCollectionName { get; set; }
		public string InventoryCollectionName { get; set; }
		public string NewPlayerDataCollectionName { get; set; }
		public string PlayerStatsCollectionName { get; set; }
		public string PositionCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}
}
