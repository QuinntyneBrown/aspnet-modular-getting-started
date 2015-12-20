namespace Chloe.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chloe.Data.ChloeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Chloe.Data.ChloeContext context)
        {
            ComponentConfiguration.Seed(context);
            PageConfiguration.Seed(context);
        }
    }
}
