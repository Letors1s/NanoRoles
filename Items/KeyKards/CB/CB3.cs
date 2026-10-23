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
    public class CB3 : CustomKeycard
    {
        public override uint Id { get; set; } = 10;
        public override string Name { get; set; } = "Ключ-карта Лейтенанта СБ";
        public override string Description { get; set; } = "";
        public override float Weight { get; set; } = 1f;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties();
        public override ItemType Type { get; set; } = ItemType.KeycardCustomMetalCase;
        public override Vector3 Scale { get; set; } = new Vector3(1.2f, 1.2f, 1.2f);


        public override string KeycardLabel { get; set; } = "ЛЕЙТЕНАНТ СБ";
        public override Color32? KeycardLabelColor { get; set; } = Color.white;
        public override string KeycardName { get; set; } = "LeutenantCBKCard";
        public override Color32? KeycardPermissionsColor { get; set; } = new Color(29, 26, 54, 255);
        public override Color32? TintColor { get; set; } = new Color(29, 26, 54, 255);
        public override byte Wear { get; set; } = 255;
        public override KeycardPermissions Permissions { get; set; } =
            KeycardPermissions.ArmoryLevelOne |
            KeycardPermissions.ArmoryLevelTwo |
            KeycardPermissions.ContainmentLevelTwo |
            KeycardPermissions.Checkpoints |
            KeycardPermissions.Intercom;
    }
}
