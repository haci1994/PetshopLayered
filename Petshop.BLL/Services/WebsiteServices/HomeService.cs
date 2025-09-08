using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.WebsiteViewModels;

namespace Petshop.BLL.Services.WebsiteServices
{
    public class HomeService
    {
        private readonly ISiteInfoService _siteInfoService;
        private readonly ICategoryService _categoryService;

        public HomeService(ISiteInfoService siteInfoService, ICategoryService categoryService)
        {
            _siteInfoService = siteInfoService;
            _categoryService = categoryService;
        }

        public async Task<HomeViewModel> GetHomepageData()
        {
            var siteInfo = await _siteInfoService.GetAllAsync(x => x != null);
            var categories = await _categoryService.GetAllAsync().ToList();

            var homeViewModel = new HomeViewModel
            {
                SiteInfoViewModel = siteInfo.FirstOrDefault(),
                Categories = categories
            };

        }
    }
}
