using MonsterSlayersAPI.SharedDefinitions.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.SharedDefinitions.Interfaces
{
	public interface IMapController
	{
		Task<PositionDTO> GetPlayerPosition();
	}
}
