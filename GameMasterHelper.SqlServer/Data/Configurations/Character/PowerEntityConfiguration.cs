using GameMasterHelper.SqlServer.Data.Entities.CharaFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterHelper.SqlServer.Data.Configurations.Character
{
    public sealed class PowerEntityConfiguration : IEntityTypeConfiguration<PowerEntity>
    {
        public void Configure(EntityTypeBuilder<PowerEntity> builder)
        {
            builder.ToTable("Powers");
            builder.HasKey(x => x.Id);

            builder.HasMany(p => p.CharacterPowers)
                .WithOne(cp => cp.PowerEntity)
                .HasForeignKey(cp => cp.PowerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
