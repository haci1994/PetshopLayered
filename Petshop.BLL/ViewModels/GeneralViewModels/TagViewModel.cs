namespace Petshop.BLL.ViewModels.GeneralViewModels
{
    public class TagViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class CreateTagViewModel
    {
        public string Name { get; set; } = null!;
    }

    public class UpdateTagViewModel
    {
        public string Name { get; set; } = null!;
    }
}
