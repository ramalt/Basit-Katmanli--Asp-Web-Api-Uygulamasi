using EmlakApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmlakApp.DataAccess
{
    public class EmlakContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source = MACBETH;Database=EmlakDb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }

        public DbSet<Ev> Evler { get; set; }
    }
}