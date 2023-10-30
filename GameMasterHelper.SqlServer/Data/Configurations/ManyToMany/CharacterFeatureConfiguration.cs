using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GameMasterHelper.SqlServer.Data.Configurations.ManyToMany
{
    public sealed class CharacterFeatureConfiguration : IEntityTypeConfiguration<CharacterFeature>
    {
        public void Configure(EntityTypeBuilder<CharacterFeature> builder)
        {
            builder.ToTable("CharacterFeature");
            builder.HasKey(x => x.Id);
        }
    }
}
