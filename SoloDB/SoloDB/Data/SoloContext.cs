using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoloDB.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SoloDB.Data
{
    public class SoloContext : DbContext
    {
        public DbSet<Models.Console> Consoles {get; set;}
        public DbSet<Game> Games { get; set; }

        public SoloContext()
            : base("SoloContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}