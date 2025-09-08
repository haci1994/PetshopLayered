using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.DAL.DataContext.Repositories
{
    public class SlideRepository : EfCoreRepository<Slide>, ISlideRepository
    {
        public SlideRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
