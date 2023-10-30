using GameMasterHelper.SqlServer.Data.Entities.Inventory;

namespace GameMasterHelper.SqlServer.Data.Entities.Enums
{
    public class ArmourTypeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<ArmourEntity> Armour { get; set; }

        public ArmourTypeEntity(string name)
        {
            Name = name;
        }
    }
}
