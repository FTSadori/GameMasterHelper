using GameMasterHelper.SqlServer.Data.Entities.Character;
using GameMasterHelper.SqlServer.Data.Entities.Enums;

namespace GameMasterHelper.SqlServer.Data.Entities.ManyToMany
{
    public class CharacterSkill
    {
        public CharacterSkill(int skillId, int characterId, string value)
        {
            SkillId = skillId;
            CharacterId = characterId;
            Value = value;
        }

        public int Id { get; set; }
        
        public int CharacterId { get; set; }
        public virtual CharacterEntity CharacterEntity { get; set; }

        public int SkillId { get; set; }
        public virtual SkillEntity SkillEntity { get; set; }
    
        public string Value { get; set; }
    }
}
