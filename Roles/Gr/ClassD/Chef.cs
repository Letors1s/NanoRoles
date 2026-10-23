using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.Gr.ClassD
{
    [CustomRole(RoleTypeId.ClassD)]
    public class Chef : CustomRole
    {
        public override uint Id { get; set; } = 4;
        public override int MaxHealth { get; set; } = 100;
        public override string Name { get; set; } = "Повар";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Повар";
        public override RoleTypeId Role { get; set; } = RoleTypeId.ClassD;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties()
        {
            Limit = 1,
            RoleSpawnPoints = new List<RoleSpawnPoint>()
                {
                    new RoleSpawnPoint()
                    {
                        Chance = 100,
                        Role = RoleTypeId.ClassD
                    }
                }
        };
        public override float SpawnChance { get; set; } = 15f;

        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Coin.ToString(),
            ItemType.KeycardJanitor.ToString()
        };
    }
}
