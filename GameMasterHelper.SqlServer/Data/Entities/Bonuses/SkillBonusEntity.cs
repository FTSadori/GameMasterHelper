using GameMasterHelper.SqlServer.Data.Entities.Description;
using GameMasterHelper.SqlServer.Data.Entities.Enums;

namespace GameMasterHelper.SqlServer.Data.Entities.Bonuses
{
    public class SkillBonusEntity
    {
        public int Id { get; set; }

        public int SkillId { get; set; }
        public virtual SkillEntity SkillEntity { get; set; }

        public int FeatureId { get; set; }
        public virtual FeatureEntity FeatureEntity { get; set; }

        public int Bonus { get; set; }

        public SkillBonusEntity(int skillId, int bonus, int featureId)
        {
            SkillId = skillId;
            Bonus = bonus;
            FeatureId = featureId;
        }
    }
}
