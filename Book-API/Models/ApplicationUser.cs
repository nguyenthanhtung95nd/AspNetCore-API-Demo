using Microsoft.AspNetCore.Identity;

namespace Book_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
