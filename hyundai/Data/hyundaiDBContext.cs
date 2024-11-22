using Microsoft.EntityFrameworkCore;
namespace hyundai.Data
{
    public class hyundaiDBContext : DbContext
    {
        public hyundaiDBContext(DbContextOptions<hyundaiDBContext> options): base(options) 
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Cars> Cars { get; set; }

    }
}
