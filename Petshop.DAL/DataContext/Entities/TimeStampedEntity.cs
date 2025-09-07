namespace Petshop.DAL.DataContext.Entities
{
    public class TimeStampedEntity : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}