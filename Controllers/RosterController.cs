using FootballRosterAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballRosterAPI.Controllers
{
    public class RosterController : Controller
    {
        private ILogger _logger;
        private IRosterService _service;
        private List<Player> _players;

        public RosterController(ILogger<RosterController> logger, IRosterService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("/api/roster")]
        public ActionResult<List<Player>> GetPlayers()
        {
            var players = _service.GetAllPlayers();
            return players;
        }

        [HttpGet("/api/roster/{id}")]
        public ActionResult<Player> GetPlayerById(int id)
        {
            var player = _service.GetPlayerById(id);
            if (player == null)
            {
                return NotFound();
            }
            return player;
        }

        [HttpPost("/api/roster")]
        public ActionResult<Player> AddPlayer(Player player)
        {
            _service.AddPlayer(player);
            return player;
        }

        [HttpPut("/api/roster/{id}")]
        public ActionResult<Player> UpdatePlayer(int id, Player player)
        {
            _service.UpdatePlayer(id, player);
            return player;
        }

        [HttpDelete("/api/roster/{id}")]
        public ActionResult<string> DeletePlayer(int id)
        {
            _service.DeletePlayer(id);
            return id.ToString();
        }
    }
}
