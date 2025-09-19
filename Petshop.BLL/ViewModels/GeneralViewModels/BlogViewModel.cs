using Microsoft.AspNetCore.Http;

namespace Petshop.BLL.ViewModels.GeneralViewModels
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ImageUrl { get; set; }
        public string? ShortMonth { get; set; }
        public string? DayOfMonth { get; set; }
    }

    public class CreateBlogViewModel
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public IFormFile? Image { get; set; }
    }

    public class UpdateBlogViewModel
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public IFormFile? Image { get; set; }
    }
}
