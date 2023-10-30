using GameMasterHelper.SqlServer.Data.Entities.Description;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterHelper.SqlServer.Data.Configurations.Character
{
    public sealed class FeatureEntityConfiguration : IEntityTypeConfiguration<FeatureEntity>
    {
        public void Configure(EntityTypeBuilder<FeatureEntity> builder)
        {
            builder.ToTable("Features");
            builder.HasKey(x => x.Id);

            builder.HasMany(c => c.AttributesBonuses)
                .WithOne(a => a.FeatureEntity)
                .HasForeignKey(a => a.FeatureId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.SkillBonuses)
                .WithOne(s => s.FeatureEntity)
                .HasForeignKey(s => s.FeatureId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.CharacterFeatures)
                .WithOne(c => c.FeatureEntity)
                .HasForeignKey(c => c.FeatureId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
