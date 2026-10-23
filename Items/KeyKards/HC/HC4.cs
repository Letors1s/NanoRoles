using Exiled.API.Enums;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NanoRoles.Items.KeyKards.HC
{
    public class HC4 : CustomKeycard
    {
        public override uint Id { get; set; } = 4;
        public override string Name { get; set; } = "Ключ-карта руководителя НС";
        public override string Description { get; set; } = "";
        public override float Weight { get; set; } = 1f;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties();
        public override ItemType Type { get; set; } = ItemType.KeycardCustomSite02;
        public override Vector3 Scale { get; set; } = new Vector3(1.2f, 1.2f, 1.2f);


        public override string KeycardLabel { get; set; } = "РУКОВОДИТЕЛЬ НАУЧНОЙ СЛУЖБЫ";
        public override Color32? KeycardLabelColor { get; set; } = Color.white;
        public override string KeycardName { get; set; } = "ResSuperKCard";
        public override Color32? KeycardPermissionsColor { get; set; } = new Color(186, 146, 0, 255);
        public override Color32? TintColor { get; set; } = new Color(186, 146, 0, 255);
        public override byte Wear { get; set; } = 255;
        public override KeycardPermissions Permissions { get; set; } =
            KeycardPermissions.ArmoryLevelOne |
            KeycardPermissions.Checkpoints |
            KeycardPermissions.ContainmentLevelOne |
            KeycardPermissions.ContainmentLevelThree |
            KeycardPermissions.ContainmentLevelTwo |
            KeycardPermissions.ExitGates |
            KeycardPermissions.Intercom;
    }
}
