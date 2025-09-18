namespace Petshop.BLL.ViewModels.GeneralViewModels
{
    public class BlogCommentViewModel
    {
        public int Id { get; set; }
        public bool IsEdited { get; set; }
        public int ParentCommentId { get; set; }
        public int BlogId { get; set; }
        public string? AuthorName { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CreateBlogCommentViewModel
    {
        public int ParentCommentId { get; set; }
        public int BlogId { get; set; }
        public string? AuthorName { get; set; }
        public string? AuthorEmail { get; set; }
        public string CommentText { get; set; } = null!;
        public string? AuthorId { get; set; }
    }

    public class UpdateBlogCommentViewModel
    {
        public string? CommentText { get; set; }
        public bool IsEdited { get; set; } = true;

    }
}
