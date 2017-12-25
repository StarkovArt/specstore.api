using application.webApi.DataLayer.Entity;
using System.Threading.Tasks;

namespace application.webApi.DataLayer.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<bool> ProductExists(int id);
    }
}