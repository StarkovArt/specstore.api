using application.webApi.DataLayer.Entity;
using System.Data.Entity;

namespace application.webApi.DataLayer.Context
{
    public class ProductDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        //public ProductDbContext()
        //{
        //    Database.SetInitializer<ProductDbContext>(new ApplicationDbIntializer());
        //}
    }

}
