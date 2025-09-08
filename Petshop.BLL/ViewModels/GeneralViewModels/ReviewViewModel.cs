using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.ViewModels.GeneralViewModels
{
    public class ReviewViewModel
    {
        public float? Rating { get; set; }

        public string? Comment { get; set; }

        public string? ReviewImageName { get; set; }

        public string? Name { get; set; } = null!;

        public ReviewStatus Status { get; set; } = ReviewStatus.Pending;

        public string? MailAddress { get; set; } = null!;

        // Navigation properties

        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public string? AppUserId { get; set; }

        public AppUser? AppUser { get; set; }
    }

    public class CreateReviewViewModel
    {
        public float Rating { get; set; }

        public string Comment { get; set; } = null!;

        public string? ReviewImageName { get; set; }

        public string Name { get; set; } = null!;

        public string MailAddress { get; set; } = null!;

        // Navigation properties
        public int ProductId { get; set; }
        public string? AppUserId { get; set; }
    }

    public class UpdateReviewViewModel
    {
        public float? Rating { get; set; }

        public string? Comment { get; set; }

        public string? ReviewImageName { get; set; }

        public string? Name { get; set; }

        public ReviewStatus? Status { get; set; }

        public string? MailAddress { get; set; }
    }
}
