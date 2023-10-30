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
    public sealed class WeaponEntityConfiguration : IEntityTypeConfiguration<WeaponEntity>
    {
        public void Configure(EntityTypeBuilder<WeaponEntity> builder)
        {
            builder.ToTable("Weapons");
            builder.HasKey(x => x.Id);

            builder.HasMany(w => w.CharacterWeapons)
                .WithOne(cp => cp.WeaponEntity)
                .HasForeignKey(we => we.WeaponId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
