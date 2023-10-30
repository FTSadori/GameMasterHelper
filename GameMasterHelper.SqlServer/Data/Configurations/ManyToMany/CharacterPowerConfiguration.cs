using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterHelper.SqlServer.Data.Configurations.ManyToMany
{
    public sealed class CharacterPowerConfiguration : IEntityTypeConfiguration<CharacterPower>
    {
        public void Configure(EntityTypeBuilder<CharacterPower> builder)
        {
            builder.ToTable("CharacterPower");
            builder.HasKey(x => x.Id);
        }
    }
}
