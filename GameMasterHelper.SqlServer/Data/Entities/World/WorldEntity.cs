using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;

namespace GameMasterHelper.SqlServer.Data.Entities.World
{
    public class WorldEntity
    {
        public WorldEntity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<WorldPlayer> WorldPlayers { get; set; }
        public virtual List<WorldNPC> WorldNPCs { get; set; }
    }
}
