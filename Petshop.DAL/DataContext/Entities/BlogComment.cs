namespace Petshop.DAL.DataContext.Entities
{
    public class BlogComment : TimeStampedEntity
    {
        public int ParentCommentId { get; set; }

        public bool IsEdited { get; set; } = false;

        public string? AuthorName { get; set; }

        public string? AuthorEmail { get; set; }

        public required string CommentText { get; set; }

        public string? AuthorId { get; set; }

        public AppUser? Author { get; set; }

        public required string Content { get; set; }

        // Foreign key
        public required int BlogId { get; set; }

        // Navigation property
        public Blog? Blog { get; set; }
    }
}
