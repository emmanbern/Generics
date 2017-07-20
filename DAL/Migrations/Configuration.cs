namespace DAL.Migrations
{
    using Model;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DataContexts.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DAL.DataContexts.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
             new Product { IsActive = true, IsVisible = false },
             new Product { IsVisible = true, IsActive = false },
             new Product { IsVisible = true, IsActive = true },
             new Product { IsVisible = false, IsActive = false }
            );

            context.Promotions.AddOrUpdate(
            new Promotion { IsActive = true, IsVisible = false },
            new Promotion { IsVisible = true, IsActive = false },
            new Promotion { IsActive = true, IsVisible = true }
           );
            //
        }
    }
}
