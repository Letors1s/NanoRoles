using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.Gr.MP
{
    public class Doctor : CustomRole
    {
        public override uint Id { get; set; } = 12;
        public override int MaxHealth { get; set; } = 100;
        public override string Name { get; set; } = "Врач Комплекса";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Врач Комплекса";
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scientist;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties()
        {
            Limit = 3,
            RoleSpawnPoints = new List<RoleSpawnPoint>()
                {
                    new RoleSpawnPoint()
                    {
                        Chance = 100,
                        Role = RoleTypeId.Scientist
                    }
                }
        };
        public override float SpawnChance { get; set; } = 15f;

        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            "7",
            ItemType.Flashlight.ToString(),
            ItemType.Radio.ToString(),
        };
    }
}
