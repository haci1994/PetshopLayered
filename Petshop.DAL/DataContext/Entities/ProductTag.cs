namespace Petshop.DAL.DataContext.Entities
{
    public class ProductTag : BaseEntity
    {
        public required int ProductId { get; set; }
        public Product? Product { get; set; }
        public required int TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}