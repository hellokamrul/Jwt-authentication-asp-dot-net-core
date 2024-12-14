using Microsoft.AspNetCore.Identity;

namespace User_Role_Management.Models.Domain
{
    public class ApplicationUser: IdentityUser
    {
        public string? Name { get; set; }
    }
}
