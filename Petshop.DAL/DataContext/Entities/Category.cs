namespace Petshop.DAL.DataContext.Entities
{
    public class Category : TimeStampedEntity
    {
        public required string Name { get; set; }

        // Navigation property
        public List<Product> Products { get; set; } = [];

    }
}