using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sports.Models
{
    public class Sport
    {
        public int SportID { get; set; }
        public string Name { get; set; }
    }
    public class SportDbContext : DbContext
    {
        public DbSet<Sport> Sports { get; set; }
    }
}