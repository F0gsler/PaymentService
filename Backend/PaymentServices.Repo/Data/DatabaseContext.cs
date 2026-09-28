using Microsoft.EntityFrameworkCore;
using PaymentServices.Repo.Models;

namespace PaymentServices.Repo.Data
{
    public class DatabaseContext : DbContext
    {
        // add-migration name
        // update-database

        // EF core fejl =>
        // slet migration mappe
        // slet database og vinke af slet forbindelse (keep alive)
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        public DbSet<Payment> Payment { get; set; }



    }
}
