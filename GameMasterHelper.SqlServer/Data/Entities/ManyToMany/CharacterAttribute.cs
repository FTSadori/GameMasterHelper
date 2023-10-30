using GameMasterHelper.SqlServer.Data.Entities.Character;
using GameMasterHelper.SqlServer.Data.Entities.Enums;

namespace GameMasterHelper.SqlServer.Data.Entities.ManyToMany
{
    public class CharacterAttribute
    {
        public CharacterAttribute(int attributeId, int characterId, string value)
        {
            AttributeId = attributeId;
            CharacterId = characterId;
            Value = value;
        }

        public int Id { get; set; }

        public int CharacterId { get; set; }
        public virtual CharacterEntity CharacterEntity { get; set; }

        public int AttributeId { get; set; }
        public virtual AttributeEntity AttributeEntity { get; set; }

        public string Value { get; set; }
    }
}
