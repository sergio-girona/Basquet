using Microsoft.EntityFrameworkCore;

namespace mba.basquet {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Team> Teams { get; set; }
        
        public DbSet<Competes> Competes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompetesConfiguration());
        }
    }
}