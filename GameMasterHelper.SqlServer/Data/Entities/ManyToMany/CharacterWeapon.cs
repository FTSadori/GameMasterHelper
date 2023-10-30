using GameMasterHelper.SqlServer.Data.Entities.Character;
using GameMasterHelper.SqlServer.Data.Entities.Inventory;

namespace GameMasterHelper.SqlServer.Data.Entities.ManyToMany
{
    public class CharacterWeapon
    {
        public CharacterWeapon(int characterId, int weaponId)
        {
            CharacterId = characterId;
            WeaponId = weaponId;
        }

        public int Id { get; set; }

        public int CharacterId { get; set; }
        public virtual CharacterEntity CharacterEntity { get; set; }

        public int WeaponId { get; set; }
        public virtual WeaponEntity WeaponEntity { get; set; }
    }
}
