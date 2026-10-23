using Exiled.API.Features;
using Exiled.CustomItems.API;
using Exiled.CustomRoles.API;
using NanoRoles.Items.KeyKards.AP;
using NanoRoles.Items.KeyKards.CB;
using NanoRoles.Items.KeyKards.GBR;
using NanoRoles.Items.KeyKards.HC;
using NanoRoles.Items.KeyKards.MP;
using NanoRoles.Roles.GBR;
using NanoRoles.Roles.Gr.AP;
using NanoRoles.Roles.Gr.CB;
using NanoRoles.Roles.Gr.ClassD;
using NanoRoles.Roles.Gr.HC;
using NanoRoles.Roles.Gr.MP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NanoRoles.Handlers.Serwer;
using NanoRoles.Roles.E11;
using NanoRoles.Roles.E_11;
using NanoRoles.Items.KeyKards.E11;
using NanoRoles.Roles.CI;
using NanoRoles.Roles.CI.A;
using NanoRoles.Roles.CI.B;
using NanoRoles.Roles.CI.Y;

namespace NanoRoles
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "NanoRoles";

        public override string Author => "Letors1s";

        public override Version RequiredExiledVersion => new Version(9, 15, 2);
        public override Version Version => new Version(1, 0, 0);


        public static Plugin pl;
        public int NtfWawes = 0;


        public HC1 hC1 { get; set; }
        public HC2 hC2 { get; set; }
        public HC3 hC3 { get; set; }
        public HC4 hC4 { get; set; }

        public AP1 aP1 { get; set; }
        public AP2 aP2 { get; set; }

        public MP1 mP1 { get; set; }

        public CB1 cB1 { get; set; }
        public CB2 cB2 { get; set; }
        public CB3 cB3 { get; set; }
        public CB4 cB4 { get; set; }

        public GBR1 gBR1 { get; set; }
        public GBR2 gBR2 { get; set; }

        public E111 e111 { get; set; }
        public E112 e112 { get; set; }
        public E113 e113 { get; set; }
        //

        public ClassDSt classDSt { get; set; }
        public Bunt bunt { get; set; }
        public Janitor janitor { get; set; }
        public Chef chef { get; set; }

        public LabAssist labAssist { get; set; }
        public Scientist scientist { get; set; }
        public StScientist stscientist { get; set; }
        public ScientistSuperv scientistuperv { get; set; }

        public LczManager lczManager { get; set; }
        public HczManager hczManager { get; set; }
        public Director director { get; set; }

        public Doctor doctor { get; set; }

        public CBPrivate cBPrivate { get; set; }
        public CBSergant cBSergant { get; set; }
        public CBLeutenant cBLeutenant { get; set; }
        public CBKapitan cBKapitan { get; set; }

        public OperGBR operGBR { get; set; }
        public MedicGBR medicGBR { get; set; }
        public KapitanGBR kapitanGBR { get; set; }

        public PrivateE11 privateE11 { get; set; }
        public MedicE11 medicE11 { get; set; }
        public ScherjantE11 scherjantE11 { get; set; }
        public CapitanE11 capitanE11 { get; set; }

        public AlfaCI alfaCI { get; set; }
        public ShturmCI shturmCI { get; set; }
        public MedicCI medicCI { get; set; }
        public BetaCI betaCI { get; set; }
        public GammaCI gammaCI { get; set; }

        public override void OnEnabled()
        {
            pl = this;
            Exiled.Events.Handlers.Server.RespawningTeam += RespawnedTeamH.RespawnedTeam;

            hC1 = new HC1();
            hC2 = new HC2();
            hC3 = new HC3();
            hC4 = new HC4();

            aP1 = new AP1();
            aP2 = new AP2();

            mP1 = new MP1();

            cB1 = new CB1();
            cB2 = new CB2();
            cB3 = new CB3();
            cB4 = new CB4();

            gBR1 = new GBR1();
            gBR2 = new GBR2();

            e111 = new E111();
            e112 = new E112();
            e113 = new E113();


            classDSt = new ClassDSt();
            bunt = new Bunt();
            janitor = new Janitor();
            chef = new Chef();

            labAssist = new LabAssist();
            scientist = new Scientist();
            stscientist = new StScientist();
            scientistuperv = new ScientistSuperv();

            lczManager = new LczManager();
            hczManager = new HczManager();
            director = new Director();

            doctor = new Doctor();

            cBPrivate = new CBPrivate();
            cBSergant = new CBSergant();
            cBLeutenant = new CBLeutenant();
            cBKapitan = new CBKapitan();

            operGBR = new OperGBR();
            medicGBR = new MedicGBR();
            kapitanGBR = new KapitanGBR();

            privateE11 = new PrivateE11();
            medicE11 = new MedicE11();
            scherjantE11 = new ScherjantE11();
            capitanE11 = new CapitanE11();

            alfaCI = new AlfaCI();
            shturmCI = new ShturmCI();
            betaCI = new BetaCI();
            medicCI = new MedicCI();
            gammaCI = new GammaCI();


            hC1.Register();
            hC2.Register();
            hC3.Register();
            hC4.Register();

            aP1.Register();
            aP2.Register();

            mP1.Register();

            cB1.Register();
            cB2.Register();
            cB3.Register();
            cB4.Register();

            gBR1.Register();
            gBR2.Register();

            e111.Register();
            e112.Register();
            e113.Register();
            //

            classDSt.Register();
            bunt.Register();
            janitor.Register();
            chef.Register();

            labAssist.Register();
            scientist.Register();
            stscientist.Register();
            scientistuperv.Register();

            lczManager.Register();
            hczManager.Register();
            director.Register();

            doctor.Register();

            cBPrivate.Register();
            cBSergant.Register();
            cBLeutenant.Register();
            cBKapitan.Register();

            operGBR.Register();
            medicGBR.Register();
            kapitanGBR.Register();

            privateE11.Register();
            medicE11.Register();
            scherjantE11.Register();
            capitanE11.Register();

            alfaCI.Register();
            shturmCI.Register();
            betaCI.Register();
            medicCI.Register();
            gammaCI.Register();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            classDSt.Unregister();
            bunt.Unregister();
            janitor.Unregister();
            chef.Unregister();

            labAssist.Unregister();
            scientist.Unregister();
            stscientist.Unregister();
            scientistuperv.Unregister();

            lczManager.Unregister();
            hczManager.Unregister();
            director.Unregister();

            doctor.Unregister();

            cBPrivate.Unregister();
            cBSergant.Unregister();
            cBLeutenant.Unregister();
            cBKapitan.Unregister();

            operGBR.Unregister();
            medicGBR.Unregister();
            kapitanGBR.Unregister();

            privateE11.Unregister();
            medicE11.Unregister();
            scherjantE11.Unregister();
            capitanE11.Unregister();

            alfaCI.Unregister();
            shturmCI.Unregister();
            betaCI.Unregister();
            medicCI.Unregister();
            gammaCI.Unregister();

            //

            hC1.Unregister();
            hC2.Unregister();
            hC3.Unregister();
            hC4.Unregister();

            aP1.Unregister();
            aP2.Unregister();

            mP1.Unregister();

            cB1.Unregister();
            cB2.Unregister();
            cB3.Unregister();
            cB4.Unregister();

            gBR1.Unregister();
            gBR2.Unregister();

            e111.Unregister();
            e112.Unregister();
            e113.Unregister();


            Exiled.Events.Handlers.Server.RespawningTeam -= RespawnedTeamH.RespawnedTeam;

            pl = null;
            base.OnDisabled();
        }
    }
}
