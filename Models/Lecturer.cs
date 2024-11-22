﻿using System.Collections.Generic;

namespace Contract_Monthly_Claim_System_POE.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal HourlyRate { get; set; }

        // Navigation property to show claims made by the lecturer
        public ICollection<Claim> Claims { get; set; }
        public object Username { get; internal set; }
    }
}
