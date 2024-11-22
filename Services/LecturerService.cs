using Contract_Monthly_Claim_System_POE.Data;
using Contract_Monthly_Claim_System_POE.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class LecturerService
{
    private readonly Contract_Monthly_Claim_System_POE.Data.ApplicationDbContext _context;

    public LecturerService(Contract_Monthly_Claim_System_POE.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Lecturer>> GetLecturersAsync()
    {
        return await _context.Lecturers.ToListAsync(); // Requires Microsoft.EntityFrameworkCore
    }

    public async Task UpdateLecturerAsync(Lecturer lecturer)
    {
        _context.Lecturers.Update(lecturer);
        await _context.SaveChangesAsync();
    }
}
