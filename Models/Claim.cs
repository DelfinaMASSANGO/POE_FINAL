﻿using System;

namespace Contract_Monthly_Claim_System_POE.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int LecturerID { get; set; }  // Foreign Key
        public DateTime Date { get; set; }
        public int HoursWorked { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string UploadedFileName { get; set; }
        // New property to store the verification status of the claim
        public string VerificationStatus { get; set; }
        public string RejectionReason { get; set; }

        // Additional properties
        public string Notes { get; set; }
        public string Claims { get; set; }
        public string SupportingDocumentPath { get; set; }

        // Navigation property for the lecturer who submitted the claim
        public Lecturer Lecturer { get; set; }

        // Navigation property for the approval information
        public Approval Approval { get; set; }

        public string LecturerName { get; set; }
        public decimal ApprovedAmount { get; set; }
        public DateTime DateApproved { get; set; }
        public bool IsApproved { get; set; } = true; // Default for example
    }
}
