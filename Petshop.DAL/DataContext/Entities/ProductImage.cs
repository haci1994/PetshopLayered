namespace Petshop.DAL.DataContext.Entities
{
    public class ProductImage : TimeStampedEntity
    {
        public required string ImageName { get; set; }
     
        // Navigation properties
        public required int ProductId { get; set; }
        
        public Product? Product { get; set; }
    }
}