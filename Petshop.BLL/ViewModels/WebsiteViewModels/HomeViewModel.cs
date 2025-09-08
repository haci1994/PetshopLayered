using Petshop.BLL.ViewModels.GeneralViewModels;

namespace Petshop.BLL.ViewModels.WebsiteViewModels
{
    public class HomeViewModel
    {
        public SiteInfoViewModel? SiteInfoViewModel { get; set; }
        public List<CategoryViewModel> Categories { get; set; } = [];
    }
}
