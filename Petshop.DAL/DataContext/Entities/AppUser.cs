using Microsoft.AspNetCore.Identity;

namespace Petshop.DAL.DataContext.Entities
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }

        public string? ProfilePhoto { get; set; }

        public List<Review> Reviews { get; set; } = [];
    }
}
