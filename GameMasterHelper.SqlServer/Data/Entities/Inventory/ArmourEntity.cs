using GameMasterHelper.SqlServer.Data.Entities.Enums;
using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;

namespace GameMasterHelper.SqlServer.Data.Entities.Inventory
{
    public class ArmourEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ArmourTypeId { get; set; }
        public virtual ArmourTypeEntity ArmourType { get; set; }

        public float Weight { get; set; }
        public int ArmourBonus { get; set; }

        public float Price { get; set; }

        public virtual List<CharacterArmour> CharacterArmours { get; set; }
    
        public ArmourEntity(string name, string description, int armourTypeId, float weight, int armourBonus, float price)
        {
            Name = name;
            Description = description;
            ArmourTypeId = armourTypeId;
            Weight = weight;
            ArmourBonus = armourBonus;
            Price = price;
        }
    }
}
