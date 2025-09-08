namespace Petshop.DAL.DataContext.Entities
{
    public class  SiteInfo : TimeStampedEntity
    {
        public string? LogoUrl { get; set; }
        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public string? Rights { get; set; }
    }
}