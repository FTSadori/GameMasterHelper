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
    public class AttributeEntityConfiguration : IEntityTypeConfiguration<AttributeEntity>
    {
        public void Configure(EntityTypeBuilder<AttributeEntity> builder)
        {
            builder.ToTable("Attributes");
            builder.HasKey(x => x.Id);

            builder.HasMany(a => a.SkillEntities)
                .WithOne(s => s.Attribute)
                .HasForeignKey(s => s.AttributeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.AttributeBonusEntities)
                .WithOne(ab => ab.Attribute)
                .HasForeignKey(ab => ab.AttributeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(a => a.CharacterAttributes)
                .WithOne(ca => ca.AttributeEntity)
                .HasForeignKey(ca => ca.AttributeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
