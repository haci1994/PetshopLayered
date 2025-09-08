using Petshop.DAL.DataContext.Entities;

namespace Petshop.DAL.DataContext.Repositories
{
    public class ProductImageRepository : EfCoreRepository<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
