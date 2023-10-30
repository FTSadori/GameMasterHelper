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
    public sealed class FeatureTypeEntityConfiguration : IEntityTypeConfiguration<FeatureTypeEntity>
    {
        public void Configure(EntityTypeBuilder<FeatureTypeEntity> builder)
        {
            builder.ToTable("EntityTypes");
            builder.HasKey(x => x.Id);
        }
    }
}
