using Petshop.BLL.ViewModels.GeneralViewModels;

namespace Petshop.BLL.ViewModels.WebsiteViewModels
{
    public class HomeViewModel
    {
        public SiteInfoViewModel? SiteInfoViewModel { get; set; } = default;
        public List<SocialViewModel>? Socials { get; set; } = [];
    }
}
