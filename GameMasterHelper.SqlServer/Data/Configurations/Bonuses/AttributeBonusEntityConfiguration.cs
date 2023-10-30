using GameMasterHelper.SqlServer.Data.Entities.Bonuses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterHelper.SqlServer.Data.Configurations.Bonuses
{
    public sealed class AttributeBonusEntityConfiguration : IEntityTypeConfiguration<AttributeBonusEntity>
    {
        public void Configure(EntityTypeBuilder<AttributeBonusEntity> builder)
        {
            builder.ToTable("AttributeBonuses");
            builder.HasKey(x => x.Id);
        }
    }
}
