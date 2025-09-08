namespace Petshop.BLL.ViewModels.GeneralViewModels
{
    public class SocialViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Class { get; set; }
    }

    public class CreateSocialViewModel
    {
        public string Name { get; set; } = null!;
        public string Url { get; set; } = "#";
        public string Class { get; set; } = null!;
    }

    public class UpdateSocialViewModel
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Class { get; set; }
    }
}
