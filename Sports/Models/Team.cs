using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sports.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public Sport Sport { get; set; }
        public Club Club { get; set; }
        public string Name { get; set; }
        public int PlayersNumber { get; set; }
        public List<Player> Players { get; set; }
    }
    public class TeamDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}