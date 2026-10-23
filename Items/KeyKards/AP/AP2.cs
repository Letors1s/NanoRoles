using Exiled.API.Enums;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NanoRoles.Items.KeyKards.AP
{
    public class AP2 : CustomKeycard
    {
        public override uint Id { get; set; } = 6;
        public override string Name { get; set; } = "Ключ-карта Директора зоны";
        public override string Description { get; set; } = "";
        public override float Weight { get; set; } = 1f;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties();
        public override ItemType Type { get; set; } = ItemType.KeycardCustomManagement;
        public override Vector3 Scale { get; set; } = new Vector3(1.2f, 1.2f, 1.2f);


        public override string KeycardLabel { get; set; } = "ДИРЕКТОР КОМПЛЕКСА";
        public override Color32? KeycardLabelColor { get; set; } = Color.white;
        public override string KeycardName { get; set; } = "DirectorKCard";
        public override Color32? KeycardPermissionsColor { get; set; } = new Color(153, 0, 0, 255);
        public override Color32? TintColor { get; set; } = new Color(153, 0, 0, 255);
        public override byte Wear { get; set; } = 255;
        public override KeycardPermissions Permissions { get; set; } =
            KeycardPermissions.AlphaWarhead |
            KeycardPermissions.ArmoryLevelThree |
            KeycardPermissions.ArmoryLevelTwo |
            KeycardPermissions.ArmoryLevelOne |
            KeycardPermissions.Checkpoints |
            KeycardPermissions.ContainmentLevelOne |
            KeycardPermissions.ContainmentLevelThree |
            KeycardPermissions.ContainmentLevelTwo |
            KeycardPermissions.ExitGates |
            KeycardPermissions.Intercom;
    }
}
