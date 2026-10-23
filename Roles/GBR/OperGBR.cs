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
    public class OperGBR : CustomRole
    {
        public override uint Id { get; set; } = 17;
        public override int MaxHealth { get; set; } = 110;
        public override string Name { get; set; } = "Оперативник ГБР";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Оперативник ГБР";
        public override RoleTypeId Role { get; set; } = RoleTypeId.NtfPrivate;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            "12",
            ItemType.GunCrossvec.ToString(),
            ItemType.Ammo9x19.ToString(),
            ItemType.Ammo9x19.ToString(),
            ItemType.Radio.ToString(),
            ItemType.ArmorCombat.ToString()
        };
    }
}
