using GameMasterHelper.SqlServer.Data.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterHelper.SqlServer.Data.Configurations.Enums
{
    public sealed class WeaponTypeEntityConfiguration : IEntityTypeConfiguration<WeaponTypeEntity>
    {
        public void Configure(EntityTypeBuilder<WeaponTypeEntity> builder)
        {
            builder.ToTable("WeaponTypes");
            builder.HasKey(x => x.Id);

            builder.HasMany(c => c.WeaponEntities)
                .WithOne(w => w.WeaponType)
                .HasForeignKey(w => w.WeaponTypeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
