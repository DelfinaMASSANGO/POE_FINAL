using Contract_Monthly_Claim_System_POE.Data;
using Contract_Monthly_Claim_System_POE.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ClaimService
{
    private readonly Contract_Monthly_Claim_System_POE.Data.ApplicationDbContext _context;

    public ClaimService(Contract_Monthly_Claim_System_POE.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Claims>> GetPendingClaimsAsync()
    {
        return await _context.Claims.Where(c => c.Status == "Pending").ToListAsync(); // Requires Microsoft.EntityFrameworkCore
    }

    public async Task ApproveClaimAsync(int claimId)
    {
        var claim = await _context.Claims.FindAsync(claimId);
        if (claim != null)
        {
            claim.Status = "Approved";
            _context.Claims.Update(claim);
            await _context.SaveChangesAsync();
        }
    }
}
