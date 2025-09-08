using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.DAL.DataContext.Repositories
{
    public class ReviewRepository : EfCoreRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
