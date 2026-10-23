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
    public class Bunt : CustomRole
    {
        public override uint Id { get; set; } = 2;
        public override int MaxHealth { get; set; } = 120;
        public override string Name { get; set; } = "Бунтовщик";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Бунтовщик";
        public override RoleTypeId Role { get; set; } = RoleTypeId.ClassD;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties()
        {
            Limit = 2,
            RoleSpawnPoints = new List<RoleSpawnPoint>()
            {
                new RoleSpawnPoint()
                {
                    Chance = 100,
                    Role = RoleTypeId.ClassD
                }
            }
        };
        public override float SpawnChance { get; set; } = 10f;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.GunCOM15.ToString()
        };
    }
}
