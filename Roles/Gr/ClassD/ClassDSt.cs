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
    [CustomRole(PlayerRoles.RoleTypeId.ClassD)]
    public class ClassDSt : CustomRole
    {
        public override uint Id { get; set; } = 1;
        public override int MaxHealth { get; set; } = 100;
        public override string Name { get; set; } = "";
        public override string Description { get; set; } = "Стандартный расходник.";
        public override string CustomInfo { get; set; } = "Персонал Класса D";
        public override RoleTypeId Role { get; set; } = RoleTypeId.ClassD;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties()
        {
            Limit = 100,
            RoleSpawnPoints = new List<RoleSpawnPoint>()
            {
                new RoleSpawnPoint()
                {
                    Chance = 100,
                    Role = RoleTypeId.ClassD
                }
            }
        };
        public override float SpawnChance { get; set; } = 100f;

    }
}
