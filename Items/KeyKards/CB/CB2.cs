using Exiled.API.Enums;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NanoRoles.Items.KeyKards.CB
{
    public class CB2 : CustomKeycard
    {
        public override uint Id { get; set; } = 9;
        public override string Name { get; set; } = "Ключ-карта Сержанта СБ";
        public override string Description { get; set; } = "";
        public override float Weight { get; set; } = 1f;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties();
        public override ItemType Type { get; set; } = ItemType.KeycardCustomMetalCase;
        public override Vector3 Scale { get; set; } = new Vector3(1.2f, 1.2f, 1.2f);


        public override string KeycardLabel { get; set; } = "СЕРЖАНТ СБ";
        public override Color32? KeycardLabelColor { get; set; } = Color.white;
        public override string KeycardName { get; set; } = "ScherjantCBKCard";
        public override Color32? KeycardPermissionsColor { get; set; } = new Color(35, 31, 56, 255);
        public override Color32? TintColor { get; set; } = new Color(35, 31, 56, 255);
        public override byte Wear { get; set; } = 255;
        public override KeycardPermissions Permissions { get; set; } =
            KeycardPermissions.ArmoryLevelOne |
            KeycardPermissions.ContainmentLevelOne |
            KeycardPermissions.Checkpoints |
            KeycardPermissions.Intercom;
    }
}
