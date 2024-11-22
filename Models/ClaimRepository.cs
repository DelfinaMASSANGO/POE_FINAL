using Contract_Monthly_Claim_System_POE.Models;

public static class ClaimRepository
{
    private static List<Claim> _claims = new List<Claim>
    {
        new Claim { ClaimID = 1, LecturerName = "John Doe", ApprovedAmount = 200, DateApproved = DateTime.Now },
        new Claim { ClaimID = 2, LecturerName = "Jane Smith", ApprovedAmount = 150, DateApproved = DateTime.Now.AddDays(-1) }
    };

    public static List<Claim> GetApprovedClaims()
    {
        return _claims.Where(c => c.IsApproved).ToList();
    }
}
