    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

namespace ElevenNote.MVC.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<ElevenNote.MVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ElevenNote.MVC.Models.ApplicationDbContext";
        }

        protected override void Seed(ElevenNote.MVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
