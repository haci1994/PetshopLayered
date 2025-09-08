using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.DAL.DataContext.Repositories
{
    public class TagRepository : EfCoreRepository<Tag>, ITagRepository
    {
        public TagRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
