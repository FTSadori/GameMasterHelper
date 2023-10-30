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
    public sealed class ArmourTypeEntityConfiguration : IEntityTypeConfiguration<ArmourTypeEntity>
    {
        public void Configure(EntityTypeBuilder<ArmourTypeEntity> builder)
        {
            builder.ToTable("ArmourTypes");
            builder.HasKey(x => x.Id);

            builder.HasMany(c => c.Armour)
                .WithOne(a => a.ArmourType)
                .HasForeignKey(a => a.ArmourTypeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
