using GameMasterHelper.SqlServer.Data.Entities.ManyToMany;

namespace GameMasterHelper.SqlServer.Data.Entities.CharaFeatures
{
    public class PowerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ManaConsume { get; set; }
        public int Range { get; set; }
        public int Duration { get; set; }
        public int ManaPerRound { get; set; }

        public string EffectValue { get; set; }

        public virtual List<CharacterPower> CharacterPowers { get; set; }

        public PowerEntity(string name, string description, int manaConsume, int range, int duration, int manaPerRound, string effectValue)
        {
            Name = name;
            Description = description;
            ManaConsume = manaConsume;
            Range = range;
            Duration = duration;
            ManaPerRound = manaPerRound;
            EffectValue = effectValue;
        }
    }
}
