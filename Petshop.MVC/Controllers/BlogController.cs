using Microsoft.AspNetCore.Mvc;
using Petshop.BLL.Services.WebsiteServices;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.BLL.ViewModels.WebsiteViewModels;

namespace Petshop.MVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogPageService _blogPageService;

        public BlogController(BlogPageService blogPageService)
        {
            _blogPageService = blogPageService;
        }

        public IActionResult Index()
        {
            var blogs = _blogPageService.GetAllBlogsAsync().Result;

            BlogsPageViewModel model = new BlogsPageViewModel
            {
                Blogs = blogs
            };

            return View(model);
        }

        public async Task<IActionResult> Single(int id)
        {
            SingleBlogViewModel? model = await _blogPageService.GetBlogByIdAsync(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
