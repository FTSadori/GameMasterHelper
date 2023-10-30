using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;

namespace GameMasterHelper.SqlServer.Data.Entities.Character
{
    public class CharacterEntity
    {
        public CharacterEntity(string name, string description, int running, int pace, int maxMana, int size)
        {

            Name = name;
            Description = description;
            Running = running;
            Pace = pace;
            MaxMana = maxMana;
            Size = size;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<CharacterAttribute> CharacterAttributes { get; set; }
        public virtual List<CharacterSkill> CharacterSkills { get; set; }
        public virtual List<CharacterFeature> CharacterFeatures { get; set; }
        public virtual List<CharacterPower> CharacterPower { get; set; }
        public virtual List<CharacterArmour> CharacterArmour { get; set; }
        public virtual List<CharacterWeapon> CharacterWeapon { get; set; }

        public virtual List<WorldPlayer> WorldPlayers { get; set; }
        public virtual List<WorldNPC> WorldNPCs { get; set; }

        public int Size { get; set; }
        public int Running { get; set; }
        public int Pace { get; set; }
        public int MaxMana { get; set; }
    }
}
