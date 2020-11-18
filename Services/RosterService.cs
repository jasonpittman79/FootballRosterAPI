using FootballRosterAPI.Controllers;
using FootballRosterAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballRosterAPI.Services
{
    public class RosterService : IRosterService
    {
        private List<Player> _players;

        public RosterService()
        {
            _players = new List<Player>();
        }

        [HttpGet]
        public List<Player> GetAllPlayers()
        {
            return _players;
        }

        public Player GetPlayerById(int id)
        {
            return _players.FirstOrDefault(p => p.ID == id);
        }

        public Player AddPlayer(Player player)
        {
            _players.Add(player);
            return player;
        }

        public Player UpdatePlayer(int id, Player player)
        {
            var index = _players.IndexOf(player);
            var playerToUpdate = _players.Where(p => p.ID == id).First();
            _players[index] = playerToUpdate;

            return playerToUpdate;
        }

        public string DeletePlayer(int id)
        {
            var playerToDelete = _players.Where(p => p.ID == id).First();
            var index = _players.IndexOf(playerToDelete);
            _players.RemoveAt(index);

            return id.ToString();
        }
    }
}
