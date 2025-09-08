namespace Petshop.DAL.DataContext.Entities
{
    public class  Slide : TimeStampedEntity
    {
        public required string Title { get; set; }

        public required string Description { get; set; }

        public required string ImageName { get; set; }

        public required string ButtonText { get; set; }

        public string? RedirectUrl { get; set; }

    }
}