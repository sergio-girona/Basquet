using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mba.basquet {
    public class CompetesConfiguration : IEntityTypeConfiguration<Competes>
    {
        public void Configure(EntityTypeBuilder<Competes> builder)
        {
            builder.HasKey(c => new { c.YearCompetition, c.NameTeam, c.NameDivision });
            builder.HasOne(c => c.TeamObj).WithMany(t => t.Divisions).HasForeignKey(c => c.NameTeam);
            builder.HasOne(c => c.DivisionObj).WithMany(d => d.Teams).HasForeignKey(c => c.NameDivision);
        }
    }
}