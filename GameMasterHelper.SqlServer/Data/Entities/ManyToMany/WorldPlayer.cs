using GameMasterHelper.SqlServer.Data.Entities.Character;
using GameMasterHelper.SqlServer.Data.Entities.World;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMasterHelper.SqlServer.Data.Entities.ManyToMany
{
    public class WorldPlayer
    {
        public WorldPlayer(int worldId, int characterId, int wounds, int fragile, int experience, bool nearDeath, int currentMana)
        {
            WorldId = worldId;
            CharacterId = characterId;
            Wounds = wounds;
            Fragile = fragile;
            Experience = experience;
            NearDeath = nearDeath;
            CurrentMana = currentMana;
        }

        public int Id { get; set; }

        public int WorldId { get; set; }
        public WorldEntity WorldEntity { get; set; }

        public int CharacterId { get; set; }
        public CharacterEntity CharacterEntity { get; set; }

        public int Wounds { get; set; }
        public int Fragile { get; set; }
        public int Experience { get; set; }
        public bool NearDeath { get; set; }
        public int CurrentMana { get; set; }
    }
}
