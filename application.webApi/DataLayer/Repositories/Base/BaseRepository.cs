using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using application.webApi.DataLayer.Context;
using application.webApi.DataLayer.Entity;

namespace application.webApi.DataLayer.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase, new()
    {
        protected abstract DbSet<TEntity> GetCollection(ProductDbContext context);
        public ProductDbContext MyContext()
        {
            return new ProductDbContext();
        }
        public async Task Add(TEntity entity)
        {
            using (var context = MyContext())
            {
                GetCollection(context).Add(entity);
                await context.SaveChangesAsync();
            }
        }
        public async Task<TEntity> GetAll()
        {
            using (var context = MyContext())
            {
                return await GetAll();
            }
        }
        public async Task<TEntity> Get(int id)
        {
            using (var context = MyContext())
            {
                return await GetCollection(context).FirstOrDefaultAsync(x => x.Id == id);
            }
        }
        public async Task Delete(int id)
        {
            using (var context = MyContext())
            {
                var entity = new TEntity { Id = id };
                GetCollection(context).Attach(entity);
                GetCollection(context).Remove(entity);
                await context.SaveChangesAsync();
            }
        }
        public async Task<bool> Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            try
            {
                using (var context = MyContext())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    await context.SaveChangesAsync();
                }
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

    }
}
