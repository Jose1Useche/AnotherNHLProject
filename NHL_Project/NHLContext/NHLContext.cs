using NHL_Project.Models.NHL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NHL_Project.NHLContext
{
    public class NHLContext : DbContext
    {
        public NHLContext() : base("DefaultConnection") { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}//gnftgj