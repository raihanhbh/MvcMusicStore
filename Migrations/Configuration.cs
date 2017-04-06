namespace MvcMusicStore.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMusicStore.Models.MvcMusicStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMusicStore.Models.MvcMusicStoreContext";
        }

        protected override void Seed(MvcMusicStore.Models.MvcMusicStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var artists = new List<Artist>
            {
                new Artist { FirstName = "Carson",   LastName = "Alexander" },

                new Artist { FirstName = "Meredith", LastName = "Alonso" },

                new Artist { FirstName = "Arturo",   LastName = "Anand" },

                new Artist { FirstName = "Gytis",    LastName = "Barzdukas" },

                new Artist { FirstName = "Yan",      LastName = "Li" },

                new Artist { FirstName = "Peggy",    LastName = "Justice" },

                new Artist { FirstName = "Laura",    LastName = "Norman" },

                new Artist { FirstName = "Nino",     LastName = "Olivetto" }
            };

            artists.ForEach(s => context.Artists.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();
        }
    }
}
