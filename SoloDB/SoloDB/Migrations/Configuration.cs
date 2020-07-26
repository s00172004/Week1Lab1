namespace SoloDB.Migrations
{
    using SoloDB.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoloDB.Data.SoloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SoloDB.Data.SoloContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var Games = new List<Game>
            {
                new Game()
                {
                  Name = "Red Dead Redemption",
                  Publisher = "Rockstar Games",
                  Price = 69.99
                },

                 new Game()
                {
                  Name = "Skyrim",
                  Publisher = "Bethesda Studios",
                  Price = 39.99
                },

                  new Game()
                {
                  Name = "Dark Souls",
                  Publisher = "From Software",
                  Price = 19.99
                }




        };


            var Consoles = new List<Models.Console>
            {
                new Models.Console()
                {
                  Name = "PlayStation 5",
                  Company = "Sony",
                  Price = 299.99
                
                },

             new Models.Console()
                {
                  Name = "Xbox One X",
                  Company = "Microsoft",
                  Price = 399.99
                },

              new Models.Console()
                {
                  Name = "Nintendo Switch",
                  Company = "Nintendo",
                  Price = 299.99
                }



        };
            Games.ForEach(u => context.Games.AddOrUpdate(u));
            Consoles.ForEach(u => context.Consoles.AddOrUpdate(u));

            base.Seed(context);
        }


    }
    
}
