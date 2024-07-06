using Microsoft.AspNetCore.Identity;

namespace RoleBaseAuth.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string? Name { get; set; }
        public string? profilePicture {  get; set; }
    }
}
