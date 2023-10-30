using GameMasterHelper.SqlServer.Data.Entities.Character;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterHelper.SqlServer.Data.Configurations.Character
{
    public sealed class CharacterEntityConfiguration : IEntityTypeConfiguration<CharacterEntity>
    {
        public void Configure(EntityTypeBuilder<CharacterEntity> builder)
        {
            builder.ToTable("Characters");
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.CharacterArmour)
                .WithOne(a => a.CharacterEntity)
                .HasForeignKey(a => a.CharacterId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(c => c.CharacterAttributes)
                .WithOne(a => a.CharacterEntity)
                .HasForeignKey(a => a.CharacterId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.CharacterSkills)
                .WithOne(s => s.CharacterEntity)
                .HasForeignKey(s => s.CharacterId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.CharacterFeatures)
                .WithOne(f => f.CharacterEntity)
                .HasForeignKey(f => f.CharacterId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.CharacterWeapon)
                .WithOne(w => w.CharacterEntity)
                .HasForeignKey(w => w.CharacterId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.CharacterPower)
                .WithOne(p => p.CharacterEntity)
                .HasForeignKey(p => p.CharacterId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.WorldPlayers)
                .WithOne(wp => wp.CharacterEntity)
                .HasForeignKey(wp => wp.CharacterId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(c => c.WorldNPCs)
                .WithOne(wn => wn.CharacterEntity)
                .HasForeignKey(wn => wn.CharacterId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
