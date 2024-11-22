using Contract_Monthly_Claim_System_POE.Controllers;  // Import the Controllers namespace
using Contract_Monthly_Claim_System_POE.Models;       // Import the Models namespace
using Microsoft.AspNetCore.Mvc;                       // Import ASP.NET Core MVC for ActionResult types
using Xunit;                                          // Import Xunit for unit testing
using System.Linq;                                    // Import Linq for working with collections
using Microsoft.AspNetCore.Http;                      // For IFormFile

namespace Contract_Monthly_Claim_System_POE.Tests     // Adjust the namespace to reflect the Test Project
{
    public class ClaimsControllerTests
    {
        // Test case: Valid claim submission should redirect to "ClaimSubmitted"
        [Fact]
        public void SubmitClaim_ValidClaim_RedirectsToClaimSubmitted()
        {
            // Arrange: Set up the controller and a sample claim
            var controller = new ClaimsController();   // Initialize the ClaimsController
            var lecturerID = "L001";                  // Sample Lecturer ID
            var lecturerName = "John Doe";            // Sample Lecturer Name
            var subject = "Mathematics";              // Sample Subject
            var hoursWorked = 10;                     // Hours worked
            var hourlyRate = 50m;                     // Hourly rate
            var notes = "Sample claim";               // Notes for the claim
            IFormFile file = null;                    // File (optional, can be null)

            // Act: Simulate submitting the claim
            var result = controller.SubmitClaim(lecturerID, lecturerName, subject, hoursWorked, hourlyRate, notes, file) as RedirectToActionResult;

            // Assert: Check if the result redirects to "ClaimSubmitted"
            Assert.NotNull(result);
            Assert.Equal("ClaimSubmitted", result.ActionName);
        }

        // Test case: Approving a valid claim should change its status to "Approved"
        [Fact]
        public void ApproveClaim_ValidClaim_ChangesStatusToApproved()
        {
            // Arrange: Set up the controller and a pending claim
            var controller = new ClaimsController();    // Initialize the ClaimsController
            var lecturerID = "L001";                   // Sample Lecturer ID
            var lecturerName = "John Doe";             // Sample Lecturer Name
            var subject = "Mathematics";               // Sample Subject
            var hoursWorked = 10;                      // Hours worked
            var hourlyRate = 50m;                      // Hourly rate
            var notes = "Sample claim";                // Notes for the claim
            IFormFile file = null;                     // File (optional, can be null)

            // Simulate submitting the claim (setting it as pending)
            controller.SubmitClaim(lecturerID, lecturerName, subject, hoursWorked, hourlyRate, notes, file);

            // Act: Simulate approving the claim
            controller.VerifyClaim(1, "Approve");       // Invoke the VerifyClaim method to approve the claim

            // Assert: Verify if the status of the claim is updated to "Approved"
            var claimsList = controller.ListClaims() as ViewResult;
            var claimsModel = claimsList.Model as List<Claim>;
            var approvedClaim = claimsModel.FirstOrDefault(c => c.ClaimID == 1);  // Find the claim by its ID

            // Assert that the claim was found and its status is now "Approved"
            Assert.NotNull(approvedClaim);
            Assert.Equal("Approved", approvedClaim.Status);
        }

        // Test case: Rejecting a valid claim should change its status to "Rejected"
        [Fact]
        public void RejectClaim_ValidClaim_ChangesStatusToRejected()
        {
            // Arrange: Set up the controller and a pending claim
            var controller = new ClaimsController();    // Initialize the ClaimsController
            var lecturerID = "L002";                   // Sample Lecturer ID
            var lecturerName = "Jane Doe";             // Sample Lecturer Name
            var subject = "Physics";                   // Sample Subject
            var hoursWorked = 8;                       // Hours worked
            var hourlyRate = 40m;                      // Hourly rate
            var notes = "Another sample claim";        // Notes for the claim
            IFormFile file = null;                     // File (optional, can be null)

            // Simulate submitting the claim (setting it as pending)
            controller.SubmitClaim(lecturerID, lecturerName, subject, hoursWorked, hourlyRate, notes, file);

            // Act: Simulate rejecting the claim
            controller.VerifyClaim(2, "Reject");        // Invoke the VerifyClaim method to reject the claim

            // Assert: Verify if the status of the claim is updated to "Rejected"
            var claimsList = controller.ListClaims() as ViewResult;
            var claimsModel = claimsList.Model as List<Claim>;
            var rejectedClaim = claimsModel.FirstOrDefault(c => c.ClaimID == 2);  // Find the claim by its ID

            // Assert that the claim was found and its status is now "Rejected"
            Assert.NotNull(rejectedClaim);
            Assert.Equal("Rejected", rejectedClaim.Status);
        }
    }
}
