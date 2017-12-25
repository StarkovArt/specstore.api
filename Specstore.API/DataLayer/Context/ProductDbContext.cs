using Specstore.API.DataLayer.Entity;
using System.Data.Entity;

namespace Specstore.API.DataLayer.Context
{
    public class ProductDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public ProductDbContext()
        {
            Database.SetInitializer<ProductDbContext>(new ApplicationDbIntializer());
        }
    }

}
