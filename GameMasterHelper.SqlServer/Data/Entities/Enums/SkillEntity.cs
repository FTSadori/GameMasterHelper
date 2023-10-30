using GameMasterHelper.SqlServer.Data.Entities.Bonuses;
using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;

namespace GameMasterHelper.SqlServer.Data.Entities.Enums
{
    public class SkillEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AttributeId { get; set; }
        public virtual AttributeEntity Attribute { get; set; }

        public virtual List<CharacterSkill> CharacterSkills { get; set; }
        public virtual List<SkillBonusEntity> SkillBonusEntities { get; set; }

        public SkillEntity(string name, int attributeId)
        {
            Name = name;
            AttributeId = attributeId;
        }
    }
}
