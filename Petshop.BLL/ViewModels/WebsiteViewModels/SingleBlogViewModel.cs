using Petshop.BLL.ViewModels.GeneralViewModels;

namespace Petshop.BLL.ViewModels.WebsiteViewModels
{
    public class SingleBlogViewModel
    {
        public BlogViewModel? Blog { get; set; }
        public List<BlogCommentViewModel> Comments { get; set; } = [];

        public int NextBlogId { get; set; }
        public string? NextBlogTitle { get; set; }
        public int PreviousBlogId { get; set; }
        public string? PreviousBlogTitle { get; set; }
    }
}
