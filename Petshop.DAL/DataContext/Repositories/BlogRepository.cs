using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.DAL.DataContext.Repositories
{
    public class BlogRepository : EfCoreRepository<Blog>, IBlogRepository
    {
        public BlogRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
