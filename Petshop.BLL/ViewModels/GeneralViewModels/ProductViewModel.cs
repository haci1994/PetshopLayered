using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.ViewModels.GeneralViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

        public decimal Price { get; set; }

        public string? CoverImageName { get; set; }

        public int Stock { get; set; }

        // Navigation properties
        public int CategoryId { get; set; }

        public CategoryViewModel? Category { get; set; }

        public List<ProductImage> ProductImages { get; set; } = [];

        public List<ProductTag> ProductTags { get; set; } = [];

        public List<Review> Reviews { get; set; } = [];

    }

    public class CreateProductViewModel
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

        public decimal Price { get; set; }

        public string? CoverImageName { get; set; }

        public int Stock { get; set; }

        // Navigation properties
        public int CategoryId { get; set; }
    }

    public class UpdateProductViewModel
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

        public decimal? Price { get; set; }

        public string? CoverImageName { get; set; }

        public int? Stock { get; set; }

        // Navigation properties
        public int? CategoryId { get; set; }
    }
}
