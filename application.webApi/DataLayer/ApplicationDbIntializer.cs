using application.webApi.DataLayer.Context;
using application.webApi.DataLayer.Entity;
using System;
using System.Data.Entity;

namespace application.webApi.DataLayer
{
    public class ApplicationDbIntializer : DropCreateDatabaseIfModelChanges<ProductDbContext>
    {
        protected override void Seed(ProductDbContext context)
        {
            var product = new Product
            {
                Id = 1,
                CreateAt = DateTime.Now,
                Name = "Test name product",
                Price = 300,
                Category = "Test category",
                Description = "Some description"
            };
            var product2 = new Product
            {
                Id = 2,
                CreateAt = DateTime.Now,
                Name = "Test2 name product",
                Price = 300,
                Category = "SuperTest",
                Description = "Some description"
            };
            var product3 = new Product
            {
                Id = 3,
                CreateAt = DateTime.Now,
                Name = "Test3 name product",
                Price = 400,
                Category = "Test category",
                Description = "Some description"
            };
            context.Products.Add(product);
            context.Products.Add(product2);
            context.Products.Add(product3);
            context.SaveChanges();
        }
    }
}
