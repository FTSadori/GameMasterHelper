using GameMasterHelper.SqlServer.Data.Entities.Enums;

namespace GameMasterHelper.SqlServer.Data.Entities.Bonuses
{
    public class SkillBonusEntity
    {
        public int Id { get; set; }

        public int SkillId { get; set; }
        public virtual SkillEntity Attribute { get; set; }

        public int Bonus { get; set; }

        public SkillBonusEntity(int skillId, int bonus)
        {
            SkillId = skillId;
            Bonus = bonus;
        }
    }
}
