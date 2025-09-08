namespace Petshop.BLL.ViewModels.GeneralViewModels
{
    public class SlideViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? ButtonText { get; set; }
        public string? RedirectUrl { get; set; }
    }

    public class CreateSlideViewModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Image { get; set; } = null!;
        public string ButtonText { get; set; } = null!;
        public string RedirectUrl { get; set; } = "#";
    }

    public class UpdateSlideViewModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? ButtonText { get; set; }
        public string? RedirectUrl { get; set; }
    }


}
