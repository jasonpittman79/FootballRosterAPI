using FootballRosterAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballRosterAPI.Controllers
{
    public interface IRosterService
    {
        public List<Player> GetAllPlayers();

        public Player GetPlayerById(int id);

        public Player AddPlayer(Player player);

        public Player UpdatePlayer(int id, Player player);

        public string DeletePlayer(int id);
    }
}
