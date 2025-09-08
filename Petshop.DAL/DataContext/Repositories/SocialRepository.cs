using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.DAL.DataContext.Repositories
{
    public class SocialRepository : EfCoreRepository<Social>, ISocialRepository
    {
        public SocialRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
