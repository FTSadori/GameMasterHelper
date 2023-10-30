using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterHelper.SqlServer.Data.Configurations.ManyToMany
{
    public sealed class CharacterArmourConfiguration : IEntityTypeConfiguration<CharacterArmour>
    {
        public void Configure(EntityTypeBuilder<CharacterArmour> builder)
        {
            builder.ToTable("CharacterArmour");
            builder.HasKey(x => x.Id);
        }
    }
}
