using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.CI.A
{
    public class ShturmCI : CustomRole
    {
        public override uint Id { get; set; } = 25;
        public override int MaxHealth { get; set; } = 150;
        public override string Name { get; set; } = "А - класс «Штурмовик»";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "А - класс «Штурмовик»";
        public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosRifleman;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            ItemType.Adrenaline.ToString(),
            ItemType.KeycardChaosInsurgency.ToString(),
            ItemType.GunLogicer.ToString(),
            ItemType.Ammo762x39.ToString(),
            ItemType.Ammo762x39.ToString(),
            ItemType.Ammo762x39.ToString(),
            ItemType.Ammo762x39.ToString(),
            ItemType.ArmorHeavy.ToString()
        };
    }
}
