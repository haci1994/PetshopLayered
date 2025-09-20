namespace Petshop.BLL.ViewModels.GeneralViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class CreateCategoryViewModel
    {
        public string Name { get; set; } = null!;
    }

    public class UpdateCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
