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
    public sealed class SkillEntityConfiguration : IEntityTypeConfiguration<SkillEntity>
    {
        public void Configure(EntityTypeBuilder<SkillEntity> builder)
        {
            builder.ToTable("Skills");
            builder.HasKey(x => x.Id);

            builder.HasMany(c => c.SkillBonusEntities)
                .WithOne(s => s.SkillEntity)
                .HasForeignKey(s => s.SkillId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.CharacterSkills)
                .WithOne(c => c.SkillEntity)
                .HasForeignKey(c => c.SkillId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
