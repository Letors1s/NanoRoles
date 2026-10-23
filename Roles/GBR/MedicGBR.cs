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
    public class MedicGBR : CustomRole
    {
        public override uint Id { get; set; } = 18;
        public override int MaxHealth { get; set; } = 115;
        public override string Name { get; set; } = "Парамедик ГБР";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Парамедик ГБР";
        public override RoleTypeId Role { get; set; } = RoleTypeId.NtfSergeant;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            ItemType.Medkit.ToString(),
            ItemType.Painkillers.ToString(),
            ItemType.Adrenaline.ToString(),
            "12",
            ItemType.GunCrossvec.ToString(),
            ItemType.Ammo9x19.ToString(),
            ItemType.Ammo9x19.ToString(),
            ItemType.Radio.ToString(),
            ItemType.ArmorCombat.ToString()
        };
    }
}
