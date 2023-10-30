using GameMasterHelper.SqlServer.Data.Entities.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterHelper.SqlServer.Data.Configurations.Inventory
{
    public sealed class ArmourEntityConfiguration : IEntityTypeConfiguration<ArmourEntity>
    {
        public void Configure(EntityTypeBuilder<ArmourEntity> builder)
        {
            builder.ToTable("Armour");
            builder.HasKey(x => x.Id);

            builder.HasMany(a => a.CharacterArmours)
                .WithOne(ca => ca.ArmourEntity)
                .HasForeignKey(ca => ca.ArmourId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
