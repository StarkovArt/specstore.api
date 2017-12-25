using Specstore.API.DataLayer.Context;
using Specstore.API.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Specstore.API.DataLayer.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        protected override DbSet<Product> GetCollection(ProductDbContext context)
        {
            return context.Products;
        }
    }
}