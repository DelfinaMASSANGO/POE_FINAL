namespace Contract_Monthly_Claim_System_POE.Models
{
    public class RegisterViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; } // Lecturer, Admin, or HR
    }
}
