using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballRosterAPI.Data.Models
{
    public class Player
    {
        public int ID { get; set; }
        
        public String Name { get; set; }

        public String Position { get; set; }
    }
}
