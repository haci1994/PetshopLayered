using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.BLL.ViewModels.WebsiteViewModels;

namespace Petshop.BLL.Services.WebsiteServices
{
    public class BlogPageService
    {
        private readonly IBlogService _blogService;
        private readonly IBlogCommentService _blogCommentService;
        private readonly IMapper _mapper;

        public BlogPageService(IBlogService blogService, IBlogCommentService blogCommentService, IMapper mapper)
        {
            _blogService = blogService;
            _blogCommentService = blogCommentService;
            _mapper = mapper;
        }

        public async Task<List<BlogViewModel>> GetAllBlogsAsync()
        {
            var blogs = await _blogService.GetAllAsync();

            List<BlogViewModel> viewBlogs = _mapper.Map<List<BlogViewModel>>(blogs);

            foreach (var item in viewBlogs)
            {
                item.ShortMonth = item.CreatedAt.ToString("MMM");
                item.DayOfMonth = item.CreatedAt.ToString("dd");
            }

            return viewBlogs;
        }

        public async Task<SingleBlogViewModel?> GetBlogByIdAsync(int id)
        {
            var blog = await _blogService.GetAsync(x => x.Id == id);

            if (blog == null) return null;

            var nextBlogId = (await _blogService.GetAllAsync(x => x.Id > id)).OrderBy(x => x.Id).FirstOrDefault()?.Id ?? 0;
            var nextBlogTitle = (await _blogService.GetAllAsync(x => x.Id > id)).OrderBy(x => x.Id).FirstOrDefault()?.Title ?? null;

            var previousBlogId = (await _blogService.GetAllAsync(x => x.Id < id)).OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0;
            var previousBlogTitle = (await _blogService.GetAllAsync(x => x.Id < id)).OrderByDescending(x => x.Id).FirstOrDefault()?.Title ?? null;

            if(nextBlogId == 0) nextBlogId = 0;
            if(previousBlogId == 0) previousBlogId = 0;

            var comments = await _blogCommentService.GetAllAsync(x => x.BlogId == id);

            comments = comments.OrderBy(x => x.CreatedAt).ToList();            

            var viewBlog = _mapper.Map<BlogViewModel>(blog);

            viewBlog.ShortMonth = viewBlog.CreatedAt.ToString("MMM");

            viewBlog.DayOfMonth = viewBlog.CreatedAt.ToString("dd");

            SingleBlogViewModel model = new SingleBlogViewModel
            {
                Blog = viewBlog,
                Comments = comments,
                NextBlogId = nextBlogId,
                PreviousBlogId = previousBlogId,
                NextBlogTitle = nextBlogTitle,
                PreviousBlogTitle = previousBlogTitle
            };

            return model;
        }
    }
}
