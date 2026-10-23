using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.CI.Y
{
    public class GammaCI : CustomRole
    {
        public override uint Id { get; set; } = 28;
        public override int MaxHealth { get; set; } = 175;
        public override string Name { get; set; } = "Y - класс «Стандартный»";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "Y - класс «Стандартный»";
        public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosRepressor;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            ItemType.Adrenaline.ToString(),
            ItemType.KeycardChaosInsurgency.ToString(),
            ItemType.GunRevolver.ToString(),
            ItemType.Ammo44cal.ToString(),
            ItemType.Ammo44cal.ToString(),
            ItemType.GunAK.ToString(),
            ItemType.Ammo556x45.ToString(),
            ItemType.Ammo556x45.ToString(),
            ItemType.ArmorHeavy.ToString()
        };
    }
}
