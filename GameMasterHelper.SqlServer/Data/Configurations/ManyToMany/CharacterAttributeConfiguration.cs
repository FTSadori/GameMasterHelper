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
    public sealed class CharacterAttributeConfiguration : IEntityTypeConfiguration<CharacterAttribute>
    {
        public void Configure(EntityTypeBuilder<CharacterAttribute> builder)
        {
            builder.ToTable("CharacterAttribute");
            builder.HasKey(x => x.Id);
        }
    }
}
