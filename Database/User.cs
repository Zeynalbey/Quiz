using Microsoft.AspNetCore.Identity;

namespace Quiz.Database
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }

    }
}
