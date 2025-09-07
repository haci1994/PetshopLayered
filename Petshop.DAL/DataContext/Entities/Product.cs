using Microsoft.EntityFrameworkCore;

namespace Petshop.DAL.DataContext.Entities
{
    public class Product : TimeStampedEntity
    {
        public required string Name { get; set; }

        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

        public required decimal Price { get; set; }

        public string? CoverImageName { get; set; }

        public int Stock { get; set; }

        // Navigation properties
        public required int CategoryId { get; set; }

        public Category? Category { get; set; }

        public List<ProductImage> ProductImages { get; set; } = [];

        public List<ProductTag> ProductTags { get; set; } = [];

        public List<Review> Reviews { get; set; } = [];

    }
}