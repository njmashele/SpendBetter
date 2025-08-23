using Microsoft.EntityFrameworkCore;

namespace SpendBetter.Models
{
    public class SpendBetterDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendBetterDbContext(DbContextOptions<SpendBetterDbContext> options)
            : base(options)
        {
                
        }
    }
}
