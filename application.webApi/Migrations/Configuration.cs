namespace application.webApi.Migrations
{
    using DataLayer.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<application.webApi.DataLayer.Context.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "application.webApi.DataLayer.Context.ProductDbContext";
        }

        protected override void Seed(application.webApi.DataLayer.Context.ProductDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(x => x.Id,
      new Product() { Id = 1, Name = "Jane Austen1", Category = "Test", CreateAt = DateTime.Now, Description = "Test", Price = 100 },
      new Product() { Id = 2, Name = "Jane Austen2", Category = "Test", CreateAt = DateTime.Now, Description = "Test", Price = 200 },
      new Product() { Id = 3, Name = "Jane Austen3", Category = "Test", CreateAt = DateTime.Now, Description = "Test", Price = 300 }
      );
        }
    }
}
