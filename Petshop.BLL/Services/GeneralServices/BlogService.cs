using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.BLL.Services.GeneralServices
{
    public class  BlogService : GenericService<Blog, CreateBlogViewModel,UpdateBlogViewModel, BlogViewModel>, IBlogService
    {
        public BlogService(IRepository<Blog> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
