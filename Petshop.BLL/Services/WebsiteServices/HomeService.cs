using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.BLL.ViewModels.WebsiteViewModels;

namespace Petshop.BLL.Services.WebsiteServices
{
    public class HomeService
    {
        private readonly ISiteInfoService _siteInfoService;
        private readonly ISocialService _socialService;
        //private readonly ICategoryService _categoryService;

        public HomeService(ISiteInfoService siteInfoService, ICategoryService categoryService, ISocialService socialService)
        {
            _siteInfoService = siteInfoService;
            _socialService = socialService;
            //_categoryService = categoryService;
        }

        public async Task<HomeViewModel> GetHomepageData()
        {
            var siteInfo = await _siteInfoService.GetAsync(x=> x.Id>0);
            var socialLinks = await _socialService.GetAllAsync();
            //var categories = await _categoryService.GetAllAsync();

            if (siteInfo == null)
            {
                siteInfo = new SiteInfoViewModel
                {
                    Logo = "logo.png",
                    Address = "",
                    Email = "",
                    Phone = "",
                    Rights = ""
                };
            }

            var homeViewModel = new HomeViewModel
            {
                SiteInfoViewModel = siteInfo,
                Socials = socialLinks
            };

            return homeViewModel;
        }
    }
}
