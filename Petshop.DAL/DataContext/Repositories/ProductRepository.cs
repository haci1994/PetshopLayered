using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.DAL.DataContext.Repositories
{
    public class ProductRepository : EfCoreRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
