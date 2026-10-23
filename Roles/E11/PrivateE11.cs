using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.E11
{
    public class PrivateE11 : CustomRole
    {
        public override uint Id { get; set; } = 20;
        public override int MaxHealth { get; set; } = 120;
        public override string Name { get; set; } = "Рядовой МОГ E-11";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Рядовой МОГ E-11";
        public override RoleTypeId Role { get; set; } = RoleTypeId.NtfPrivate;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            "14",
            ItemType.GunCrossvec.ToString(),
            ItemType.Ammo9x19.ToString(),
            ItemType.Ammo9x19.ToString(),
            ItemType.Radio.ToString(),
            ItemType.ArmorCombat.ToString()
        };
    }
}
