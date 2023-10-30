using GameMasterHelper.SqlServer.Data.Entities.Description;

namespace GameMasterHelper.SqlServer.Data.Entities.Enums
{
    public class FeatureTypeEntity
    {
        public FeatureTypeEntity(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<FeatureEntity> FeatureEntities { get; set; }
    }
}
