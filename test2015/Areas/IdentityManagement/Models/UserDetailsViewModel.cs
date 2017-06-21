using test2015.Models;

namespace test2015.Areas.IdentityManagement.Models
{
    public class UserDetailsViewModel
    {
        public ApplicationUser User { get; set; }
        public LockoutViewModel Lockout { get; set; }
    }
}