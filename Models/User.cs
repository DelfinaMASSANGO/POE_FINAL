using Microsoft.AspNetCore.Identity;

namespace Contract_Monthly_Claim_System_POE.Models
{
    public class User
    {
        public int UserID { get; set; } // Unique ID for each user
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Role: "Lecturer", "Admin", "HR"
        public string ContactDetails { get; set; } // New field
    }


    public class Users : IdentityUser
    {
        // Add any custom properties, if needed
        public string FullName { get; set; }
    }
}
