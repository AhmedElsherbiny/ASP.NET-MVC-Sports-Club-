using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Sports.Models
{
    public class HighBoardClubMembers
    {
        public int MembersID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
    public class HighBoardClubMembersDbContext : DbContext
    {
        public DbSet<HighBoardClubMembers> HighMembers { get; set; }
    }
}
