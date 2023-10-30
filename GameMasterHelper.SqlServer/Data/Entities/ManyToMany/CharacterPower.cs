using GameMasterHelper.SqlServer.Data.Entities.Character;
using GameMasterHelper.SqlServer.Data.Entities.CharaFeatures;

namespace GameMasterHelper.SqlServer.Data.Entities.ManyToMany
{
    public class CharacterPower
    {
        public CharacterPower(int characterId, int powerId)
        {
            CharacterId = characterId;
            PowerId = powerId;
        }

        public int Id { get; set; }

        public int CharacterId { get; set; }
        public virtual CharacterEntity CharacterEntity { get; set; }

        public int PowerId { get; set; }
        public virtual PowerEntity PowerEntity { get; set; }
    }
}
