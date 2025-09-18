namespace Petshop.DAL.DataContext.Entities
{
    public class Blog : TimeStampedEntity
    {
        public required string Title { get; set; }

        public required string Content { get; set; }
        
        public string? ImageUrl { get; set; }
        
        // Navigation property
        public List<BlogComment> Comments { get; set; } = [];
    }
}
