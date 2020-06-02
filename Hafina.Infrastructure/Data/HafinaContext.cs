using Hafina.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hafina.Infrastructure.Data
{
    public class HafinaContext : DbContext
    {
        // Run command: Add-Migration InitialCreate -OutputDir "Data/Migrations" to add folder Migrations in Data folder
        public HafinaContext(DbContextOptions<HafinaContext> options) : base(options)
        {
        }

        public DbSet<BalanceSheet> BalanceSheet { get; set; }

        public DbSet<BusinessResult> BusinessResult { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<SerilogEntity> Serilog { get; set; }
    }
}
