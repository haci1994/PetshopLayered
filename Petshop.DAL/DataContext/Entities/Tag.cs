namespace Petshop.DAL.DataContext.Entities
{
    public class Tag : TimeStampedEntity
    {
        public required string Name { get; set; }
        
        // Navigation property
        public List<ProductTag> ProductTags { get; set; } = [];
    }
}