using GameMasterHelper.SqlServer.Data.Entities.Inventory;

namespace GameMasterHelper.SqlServer.Data.Entities.Enums
{
    public class WeaponTypeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<WeaponEntity> WeaponEntities { get; set; }
            
        public WeaponTypeEntity(string name)
        {
            Name = name;
        }
    }
}
