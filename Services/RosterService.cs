using FootballRosterAPI.Controllers;
using FootballRosterAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballRosterAPI.Services
{
    public class RosterService : IRosterService
    {
        private List<Player> _players;

        public RosterService()
        {
            _players = new List<Player>();
        }

        public List<Player> GetPlayers()
        {
            return _players;
        }

        public Player AddPlayer(Player player)
        {
            _players.Add(player);
            return player;
        }

        public Player UpdatePlayer(string id, Player player)
        {
            for (var index = _players.Count - 1; index >= 0; index--)
            {
                if (_players[index].ID == id)
                {
                    _players[index] = player;
                }
            }
            return player;
        }

        public string DeletePlayer(string id)
        {
            for (var index = _players.Count - 1; index >= 0; index--)
            {
                if (_players[index].ID == id)
                {
                    _players.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
