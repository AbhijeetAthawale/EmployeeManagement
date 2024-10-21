using Microsoft.AspNetCore.Identity;

namespace Employee_Management.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
