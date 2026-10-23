using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.CI.B
{
    public class BetaCI : CustomRole
    {
        public override uint Id { get; set; } = 27;
        public override int MaxHealth { get; set; } = 120;
        public override string Name { get; set; } = "B - класс «Стандартный»";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "B - класс «Стандартный»";
        public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosMarauder;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            ItemType.Adrenaline.ToString(),
            ItemType.KeycardChaosInsurgency.ToString(),
            ItemType.GunRevolver.ToString(),
            ItemType.Ammo44cal.ToString(),
            ItemType.GunAK.ToString(),
            ItemType.Ammo556x45.ToString(),
            ItemType.ArmorCombat.ToString()
        };
    }
}
