using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sports.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        public Sport Sport { get; set; }
        public Club Club { get; set; }
        public List<Team> ParticipantsTeams { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
    }
    public class MatchDbContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }
    }
}