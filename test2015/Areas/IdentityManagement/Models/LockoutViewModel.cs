using System;

namespace test2015.Areas.IdentityManagement.Models
{
    public class LockoutViewModel
    {
        public LockoutStatus Status { get; set; }
        public DateTime? LockoutEndDate { get; set; }
    }
}