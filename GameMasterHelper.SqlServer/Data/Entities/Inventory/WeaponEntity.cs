using GameMasterHelper.SqlServer.Data.Entities.Enums;
using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;

namespace GameMasterHelper.SqlServer.Data.Entities.Inventory
{
    public class WeaponEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int WeaponTypeId { get; set; }
        public virtual WeaponTypeEntity WeaponType { get; set; }

        public float WeaponWeight { get; set; }
        public int Range { get; set; }
        public int AP { get; set; }

        public int MaxAmmo { get; set; }
        public int Auto { get; set; }

        public string Damage { get; set; }

        public float Price { get; set; }

        public virtual List<CharacterWeapon> CharacterWeapons { get; set; }

        public WeaponEntity(string name, string description, int weaponTypeId, float weaponWeight, int range, int aP, int maxAmmo, int auto, float price)
        {
            Name = name;
            Description = description;
            WeaponTypeId = weaponTypeId;
            WeaponWeight = weaponWeight;
            Range = range;
            AP = aP;
            MaxAmmo = maxAmmo;
            Auto = auto;
            Price = price;
        }
    }
}
