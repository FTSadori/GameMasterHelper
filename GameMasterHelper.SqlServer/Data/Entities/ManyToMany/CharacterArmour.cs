using GameMasterHelper.SqlServer.Data.Entities.Character;
using GameMasterHelper.SqlServer.Data.Entities.Inventory;

namespace GameMasterHelper.SqlServer.Data.Entities.ManyToMany
{
    public class CharacterArmour
    {
        public CharacterArmour(int characterId, int armourId, int curAmmo)
        {
            CharacterId = characterId;
            ArmourId = armourId;
            CurAmmo = curAmmo;
        }

        public int Id { get; set; }

        public int CharacterId { get; set; }
        public virtual CharacterEntity CharacterEntity { get; set; }

        public int ArmourId { get; set; }
        public virtual ArmourEntity ArmourEntity { get; set; }

        public int CurAmmo { get; set; }
    }
}
