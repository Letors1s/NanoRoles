using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.GBR
{
    public class KapitanGBR : CustomRole
    {
        public override uint Id { get; set; } = 19;
        public override int MaxHealth { get; set; } = 120;
        public override string Name { get; set; } = "Капитан ГБР";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Капитан ГБР";
        public override RoleTypeId Role { get; set; } = RoleTypeId.NtfCaptain;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            ItemType.Adrenaline.ToString(),
            "13",
            ItemType.GunE11SR.ToString(),
            ItemType.Ammo556x45.ToString(),
            ItemType.Ammo556x45.ToString(),
            ItemType.Radio.ToString(),
            ItemType.ArmorCombat.ToString()
        };
    }
}
