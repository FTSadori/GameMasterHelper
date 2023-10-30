using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GameMasterHelper.SqlServer.Data.Configurations.ManyToMany
{
    public sealed class WorldNPCConfiguration : IEntityTypeConfiguration<WorldNPC>
    {
        public void Configure(EntityTypeBuilder<WorldNPC> builder)
        {
            builder.ToTable("WorldNPC");
            builder.HasKey(x => x.Id);
        }
    }
}
