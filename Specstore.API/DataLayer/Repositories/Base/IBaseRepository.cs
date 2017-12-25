using Specstore.API.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specstore.API.DataLayer.Repositories
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
