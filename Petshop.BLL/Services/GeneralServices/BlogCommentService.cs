using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.BLL.Services.GeneralServices
{
    public class BlogCommentService : GenericService<BlogComment, CreateBlogCommentViewModel, UpdateBlogCommentViewModel, BlogCommentViewModel>, IBlogCommentService
    {
        public BlogCommentService(IRepository<BlogComment> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
