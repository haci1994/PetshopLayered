namespace Petshop.DAL.DataContext.Entities
{
    public class  Social : TimeStampedEntity
    {
        public required string Name { get; set; }

        public string? Url { get; set; }

        public required string Class { get; set; }
    }
}