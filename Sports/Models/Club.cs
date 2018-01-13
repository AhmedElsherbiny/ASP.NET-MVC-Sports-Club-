using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sports.Models
{
    public class Club
    {
        public int ClubID { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public DateTime EstablishDate { get; set; }
        public List<HighBoardClubMembers> HighMembers  { get; set; }
    }
    public class ClubDbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
    }
}