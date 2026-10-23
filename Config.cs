using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoRoles
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;


        public string GbrCassieText = "Внимание, <color=#696969> службе безопасности. </color> <size=0> Attention . . Security Personnel. <split> </size> <color=#000080>Разведывательная Группа </color> вошла на территорию комплекса. <size=0>  Mobile Task Force has entered the facility. <split> </size> <color=#696969> Службе Безопасности </color> доложить статус комплекса <color=#000080> разведывательной группе </color> <size=0> Security Personnel report facility status to <color=#000080> Mobile Task  Force </color> <split>Доклад окончен. <size=0> . Report ended. .G2 .G5 .G1 .G3";
    }
}
