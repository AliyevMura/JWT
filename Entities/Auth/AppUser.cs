using Microsoft.AspNetCore.Identity;

namespace CarAPI.Entities.Auth
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
