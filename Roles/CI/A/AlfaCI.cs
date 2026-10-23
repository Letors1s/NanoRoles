using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles.Roles.CI
{
    public class AlfaCI : CustomRole
    {
        public override uint Id { get; set; } = 24;
        public override int MaxHealth { get; set; } = 120;
        public override string Name { get; set; } = "А - класс «Стандартный»";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "А - класс «Стандартный»";
        public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosRifleman;
        public override List<string> Inventory { get; set; } = new List<string>()
        {
            ItemType.Medkit.ToString(),
            ItemType.KeycardChaosInsurgency.ToString(),
            ItemType.GunAK.ToString(),
            ItemType.Ammo762x39.ToString(),
            ItemType.Ammo762x39.ToString(),
            ItemType.ArmorCombat.ToString()
        };
    }

}
