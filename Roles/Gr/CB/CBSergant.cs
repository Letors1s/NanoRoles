using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.Gr.CB
{
    public class CBSergant : CustomRole
    {
        public override uint Id { get; set; } = 14;
        public override int MaxHealth { get; set; } = 110;
        public override string Name { get; set; } = "Сержант СБ";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Сержант СБ";
        public override RoleTypeId Role { get; set; } = RoleTypeId.FacilityGuard;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties()
        {
            Limit = 3,
            RoleSpawnPoints = new List<RoleSpawnPoint>()
                {
                    new RoleSpawnPoint()
                    {
                        Chance = 100,
                        Role = RoleTypeId.FacilityGuard
                    }
                }
        };

        public override float SpawnChance { get; set; } = 21f;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            "9",
            ItemType.GunFSP9.ToString(),
            ItemType.Ammo9x19.ToString(),
            ItemType.Radio.ToString(),
            ItemType.ArmorCombat.ToString()
        };
    }
}
