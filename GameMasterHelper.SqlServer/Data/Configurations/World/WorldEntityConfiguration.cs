using GameMasterHelper.SqlServer.Data.Entities.World;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GameMasterHelper.SqlServer.Data.Configurations.World
{
    public sealed class WorldEntityConfiguration : IEntityTypeConfiguration<WorldEntity>
    {
        public void Configure(EntityTypeBuilder<WorldEntity> builder)
        {
            builder.ToTable("Worlds");
            builder.HasKey(x => x.Id);

            builder.HasMany(c => c.WorldPlayers)
                .WithOne(wp => wp.WorldEntity)
                .HasForeignKey(wp => wp.WorldId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.WorldNPCs)
                .WithOne(wn => wn.WorldEntity)
                .HasForeignKey(wn => wn.WorldId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
