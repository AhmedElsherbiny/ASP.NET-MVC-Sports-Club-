using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sports.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Sport Sport { get; set; }
    }
    public class PlayerDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}