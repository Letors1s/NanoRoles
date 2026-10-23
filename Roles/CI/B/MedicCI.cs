using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.CI.A
{
    public class MedicCI : CustomRole
    {
        public override uint Id { get; set; } = 26;
        public override int MaxHealth { get; set; } = 150;
        public override string Name { get; set; } = "B - класс «Парамедик»";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "B - класс «Парамедик»";
        public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosMarauder;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            ItemType.Medkit.ToString(),
            ItemType.Painkillers.ToString(),
            ItemType.Adrenaline.ToString(),
            ItemType.KeycardChaosInsurgency.ToString(),
            ItemType.GunRevolver.ToString(),
            ItemType.Ammo44cal.ToString(),
            ItemType.Ammo44cal.ToString(),
            ItemType.ArmorCombat.ToString()
        };
    }
}