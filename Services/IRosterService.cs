using FootballRosterAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballRosterAPI.Controllers
{
    public interface IRosterService
    {
        public List<Player> GetPlayers();

        public Player AddPlayer(Player rosterMember);

        public Player UpdatePlayer(string id, Player rosterMember);

        public string DeletePlayer(string id);
    }
}
