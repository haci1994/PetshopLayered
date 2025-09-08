using Microsoft.AspNetCore.Mvc;
using Petshop.BLL.Services.WebsiteServices;

namespace Petshop.MVC.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly HomeService _homeService;

        public HeaderViewComponent(HomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var homeViewModel = await _homeService.GetHomepageData();

            return View(homeViewModel);
        }
    }
}
