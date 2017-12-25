using application.webApi.DataLayer.Context;
using application.webApi.DataLayer.Entity;
using application.webApi.DataLayer.Repositories;
using System.Data.Entity;
using System.Threading.Tasks;

namespace appplication.webApi.DataLayer.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        protected override DbSet<Product> GetCollection(ProductDbContext context)
        {
            return context.Products;
        }
        public async Task<bool> ProductExists(int id)
        {
            using (var context = MyContext())
            {
                return await GetCollection(context).CountAsync(e => e.Id == id) > 0;
            }

        }
    }
}