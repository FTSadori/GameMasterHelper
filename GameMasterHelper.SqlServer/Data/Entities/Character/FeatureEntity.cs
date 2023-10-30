using GameMasterHelper.SqlServer.Data.Entities.Bonuses;
using GameMasterHelper.SqlServer.Data.Entities.Enums;
using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;

namespace GameMasterHelper.SqlServer.Data.Entities.Description
{
    public class FeatureEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<AttributeBonusEntity> AttributesBonuses { get; set; }
        public virtual List<SkillBonusEntity> SkillBonuses { get; set; }

        public virtual List<CharacterFeature> CharacterFeatures { get; set; }

        public int FeatureTypeId { get; set; }
        public virtual FeatureTypeEntity FeatureTypeEntity { get; set; }

        public int PaceBonus { get; set; }
        public int ArmourBonus { get; set; }
        public int RunningBonus { get; set; }
        public int CharismaBonus { get; set; }
        public int SizeBonus { get; set; }

        public FeatureEntity(string name, string description, int paceBonus, int armourBonus, int runningBonus, int charismaBonus, int featureTypeId, int sizeBonus)
        {
            Name = name;
            Description = description;
            PaceBonus = paceBonus;
            ArmourBonus = armourBonus;
            RunningBonus = runningBonus;
            CharismaBonus = charismaBonus;
            FeatureTypeId = featureTypeId;
            SizeBonus = sizeBonus;
        }
    }
}
