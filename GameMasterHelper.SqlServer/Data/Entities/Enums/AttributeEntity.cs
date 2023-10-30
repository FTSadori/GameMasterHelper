using GameMasterHelper.SqlServer.Data.Entities.Bonuses;
using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;
using System.ComponentModel.Design;

namespace GameMasterHelper.SqlServer.Data.Entities.Enums
{
    public class AttributeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<AttributeBonusEntity> AttributeBonusEntities { get; set; }
        public virtual List<SkillEntity> SkillEntities { get; set; }
        public virtual List<CharacterAttribute> CharacterAttributes { get; set; }

        public AttributeEntity(string name)
        {
            Name = name;
        }
    }
}
