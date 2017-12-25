using application.webApi.DataLayer.Entity;
using System.Threading.Tasks;

namespace application.webApi.DataLayer.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : EntityBase
    {
        Task<TEntity> GetAll();
        Task Add(TEntity entity);
        Task<TEntity> Get(int id);
        Task Delete(int id);
        Task<bool> Update(TEntity entity);
    }
}
