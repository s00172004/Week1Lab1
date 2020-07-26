using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SoloDB.Models;

namespace SoloDB.Data
{
    public class SoloContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Models.Console> Consoles { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}