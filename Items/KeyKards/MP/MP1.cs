using Exiled.API.Enums;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NanoRoles.Items.KeyKards.MP
{
    public class MP1 : CustomKeycard
    {
        public override uint Id { get; set; } = 7;
        public override string Name { get; set; } = "Ключ-карта Врача";
        public override string Description { get; set; } = "";
        public override float Weight { get; set; } = 1f;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties();
        public override ItemType Type { get; set; } = ItemType.KeycardCustomSite02;
        public override Vector3 Scale { get; set; } = new Vector3(1.2f, 1.2f, 1.2f);


        public override string KeycardLabel { get; set; } = "ВРАЧ";
        public override Color32? KeycardLabelColor { get; set; } = Color.white;
        public override string KeycardName { get; set; } = "DoctorKCard";
        public override Color32? KeycardPermissionsColor { get; set; } = new Color(255, 0, 72, 255);
        public override Color32? TintColor { get; set; } = new Color(255, 0, 72, 255);
        public override byte Wear { get; set; } = 255;
        public override KeycardPermissions Permissions { get; set; } =
            KeycardPermissions.Checkpoints |
            KeycardPermissions.ContainmentLevelOne;
    }
}
