using Contract_Monthly_Claim_System_POE.Data;
using Contract_Monthly_Claim_System_POE.Models;
using Microsoft.EntityFrameworkCore;

namespace Contract_Monthly_Claim_System_POE.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Claims> Claims { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Approval> Approvals { get; set; }
    }
}



