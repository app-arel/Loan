using Loan.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Loan.Data
{
    public class LoanContext : DbContext
    {
        public LoanContext(DbContextOptions<LoanContext> options): base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<LoanDetails> loans { get; set; }
    }
}
