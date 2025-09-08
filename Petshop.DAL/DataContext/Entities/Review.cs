namespace Petshop.DAL.DataContext.Entities
{
    public class Review : TimeStampedEntity
    {
        public float Rating { get; set; }

        public string Comment { get; set; } = null!;
    
        public string? ReviewImageName { get; set; }

        public string Name { get; set; } = null!;

        public ReviewStatus Status { get; set; } = ReviewStatus.Pending;

        public string MailAddress { get; set; } = null!;

        // Navigation properties

        public required int ProductId { get; set; }

        public Product? Product { get; set; }

        public string? AppUserId { get; set; }

        public AppUser? AppUser { get; set; }
    }

    public enum ReviewStatus
    {
        Pending,
        Approved,
        Rejected
    }
}