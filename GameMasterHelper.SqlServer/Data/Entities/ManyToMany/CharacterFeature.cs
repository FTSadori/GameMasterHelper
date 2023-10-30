using GameMasterHelper.SqlServer.Data.Entities.Character;
using GameMasterHelper.SqlServer.Data.Entities.Description;

namespace GameMasterHelper.SqlServer.Data.Entities.ManyToMany
{
    public class CharacterFeature
    {
        public CharacterFeature(int characterId, int featureId)
        {
            CharacterId = characterId;
            FeatureId = featureId;
        }

        public int Id { get; set; }

        public int CharacterId { get; set; }
        public virtual CharacterEntity CharacterEntity { get; set; }

        public int FeatureId { get; set; }
        public virtual FeatureEntity FeatureEntity { get; set; }
    }
}
