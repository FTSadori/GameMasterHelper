using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameMasterHelper.SqlServer.Data.Configurations.ManyToMany
{
    public sealed class WorldPlayerConfiguration : IEntityTypeConfiguration<WorldPlayer>
    {
        public void Configure(EntityTypeBuilder<WorldPlayer> builder)
        {
            builder.ToTable("WorldPlayer");
            builder.HasKey(x => x.Id);
        }
    }
}
