using GameMasterHelper.SqlServer.Data.Entities.Enums;

namespace GameMasterHelper.SqlServer.Data.Entities.Bonuses
{
    public class AttributeBonusEntity
    {
        public int Id { get; set; }

        public int AttributeId { get; set; }
        public virtual AttributeEntity Attribute { get; set; }

        public int Bonus { get; set; }

        public AttributeBonusEntity(int attributeId, int bonus)
        {
            AttributeId = attributeId;
            Bonus = bonus;
        }
    }
}
