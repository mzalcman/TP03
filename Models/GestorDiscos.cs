namespace TРОЗ.Models;

public class GestorDiscos
{
    public static Dictionary<int, Disco> Discos { get; private set; }

    public static void InicializarDiscos()
    {
    Disco disco1 = new Disco();    



    }

    private static void CargarDiscos()
    {
        Discos = new Dictionary<int, Disco>();
        List<Temas> disco1 = new List<Temas>();
        Temas d1c1 = new Temas("we can't be friends", "https://youtu.be/KNtJGQkC-WI?feature=shared");
        Temas d1c2 = new Temas("yes, and?", "https://youtu.be/eB6txyhHFG4?feature=shared");
        Temas d1c3 = new Temas("Problem", "https://youtu.be/iS1g8G_njx8?feature=shared");
        Temas d1c4 = new Temas("7 rings", "https://youtu.be/QYh6mYIJG2Y?feature=shared");
        Temas d1c5 = new Temas("Break Free", "https://youtu.be/L8eRzOYhLuw?feature=shared");
        Temas d1c6 = new Temas("Into You", "https://youtu.be/1ekZEVeXwek?feature=shared");
        Temas d1c7 = new Temas("Focus", "https://youtu.be/lf_wVfwpfp8?feature=shared");
        Temas d1c8 = new Temas("The Weeknd", "https://youtu.be/g5qU7p7yOY8?feature=shared");
        Temas d1c9 = new Temas("Thank u, next", "https://youtu.be/gl1aHhXnN1k?feature=shared");
        Temas d1c10 = new Temas("Positions", "https://youtu.be/tcYodQoapMg?feature=shared");
        disco1.Add(d1c1);
        disco1.Add(d1c2);
        disco1.Add(d1c3);
        disco1.Add(d1c4);
        disco1.Add(d1c5);
        disco1.Add(d1c6);
        disco1.Add(d1c7);
        disco1.Add(d1c8);
        disco1.Add(d1c9);
        disco1.Add(d1c10);

        List<Temas> disco2 = new List<Temas>();
        Temas d2c1 = new Temas("Ameriican Requiem", "https://youtu.be/vp3BSjJdyow?feature=shared");
        Temas d2c2 = new Temas("Blackbiird", "https://youtu.be/xhempeEjGUA?feature=shared");
        Temas d2c3 = new Temas("16 Carriages", "https://youtu.be/hhKNjTb6U1Y?feature=shared");
        Temas d2c4 = new Temas("Protector", "https://youtu.be/f4xrblI8Tvw?feature=shared");
        Temas d2c5 = new Temas("My rose", "https://youtu.be/VWfSNezeQCc?feature=shared");
        Temas d2c6 = new Temas("Bodyguard", "https://youtu.be/7HV_Rv858YM?feature=shared");
        Temas d2c7 = new Temas("Jolene", "https://youtu.be/x9XHMK3nWr4?feature=shared");
        Temas d2c8 = new Temas("Smoke hour II", "https://youtu.be/8FE9z3btl9Q?feature=shared");
        Temas d2c9 = new Temas("Just for fun", "https://youtu.be/vSZCl3Qs9rA?feature=shared");
        Temas d2c10 = new Temas("Flamenco", "https://youtu.be/SKQcy3JDrAQ?feature=shared");
        disco2.Add(d2c1);
        disco2.Add(d2c2);
        disco2.Add(d2c3);
        disco2.Add(d2c4);
        disco2.Add(d2c5);
        disco2.Add(d2c6);
        disco2.Add(d2c7);
        disco2.Add(d2c8);
        disco2.Add(d2c9);
        disco2.Add(d2c10);

        List<Temas> disco3 = new List<Temas>();
        Temas d3c1 = new Temas("Paid", "https://youtu.be/oG1xb5KOcN4?feature=shared");
        Temas d3c2 = new Temas("Keys to my life", "https://youtu.be/kX3ivxNp9PY?feature=shared");
        Temas d3c3 = new Temas("Back to me", "https://youtu.be/MiTIhSb-b2k?feature=shared");
        Temas d3c4 = new Temas("Do it", "https://youtu.be/G0hxhn7-Hps?feature=shared");
        Temas d3c5 = new Temas("Burn", "https://youtu.be/oAbX14IadBo?feature=shared");
        Temas d3c6 = new Temas("Fuck sumn", "https://youtu.be/xd2SEKy6HIM?feature=shared");
        Temas d3c7 = new Temas("Paperwork", "https://youtu.be/FmrXYkfv2eU?feature=shared");
        Temas d3c8 = new Temas("Hoodrat", "https://youtu.be/eHHwQMxvVOU?feature=shared");
        Temas d3c9 = new Temas("Problematic", "https://youtu.be/xcprkHw4cd8?feature=shared");
        Temas d3c10 = new Temas("King", "https://youtu.be/g6vAQpxo35g?feature=shared");
        disco3.Add(d3c1);
        disco3.Add(d3c2);
        disco3.Add(d3c3);
        disco3.Add(d3c4);
        disco3.Add(d3c5);
        disco3.Add(d3c6);
        disco3.Add(d3c7);
        disco3.Add(d3c8);
        disco3.Add(d3c9);
        disco3.Add(d3c10);

        List<Temas> disco4 = new List<Temas>();
        Temas d4c1 = new Temas("End Of An Era", "https://youtu.be/apSZ77414bA?si=1P_LwGvHcgkq84Ll");
        Temas d4c2 = new Temas("Houdini", "https://youtu.be/cCfPDrRQp9k?si=IQrSv_08R14u6pjH");
        Temas d4c3 = new Temas("Training Season", "https://youtu.be/n0GXk_T2zs8?si=czRgp9Ac0Plqzy3F");
        Temas d4c4 = new Temas("These Walls", "https://youtu.be/txxkp-mf1Eo?si=OuQsZJwKWU2LEGkB");
        Temas d4c5 = new Temas("Whatcha Doing", "https://youtu.be/tZ0B6L4SiBQ?si=J36XV01AaSw0oh_x");
        Temas d4c6 = new Temas("French Exit", "https://youtu.be/c-sspyeKFjI?si=pcZX7F8gbNBh8KfS");
        Temas d4c7 = new Temas("Illusion", "https://youtu.be/a9cyG_yfh1k?si=vB8ame4v5ZNQoQk9");
        Temas d4c8 = new Temas("Falling Forever", "https://youtu.be/IGM-B6CaP0c?si=iUoSsTwBoOyGjZSA");
        Temas d4c9 = new Temas("Anything For Love", "https://youtu.be/0dF1dPLF9cQ?si=LkAEU80Jqwrf1dCf");
        Temas d4c10 = new Temas("Happy For You", "https://youtu.be/KKypB3YEPe0?si=QJZIF2NXQCyDNCLU");
        disco4.Add(d4c1);
        disco4.Add(d4c2);
        disco4.Add(d4c3);
        disco4.Add(d4c4);
        disco4.Add(d4c5);
        disco4.Add(d4c6);
        disco4.Add(d4c7);
        disco4.Add(d4c8);
        disco4.Add(d4c9);
        disco4.Add(d4c10);

        List<Temas> disco5 = new List<Temas>();
        Temas d5c1 = new Temas("SKINNY", "https://youtu.be/g6YSdMnCOCU?si=d_PV8vgnMFJN5NYL");
        Temas d5c2 = new Temas("LUNCH", "https://youtu.be/MB3VkzPdgLA?si=QFNiCp-Iz_16DpRs");
        Temas d5c3 = new Temas("CHIHIRO", "https://youtu.be/BY_XwvKogC8?si=LpXCDsxOe7OqD4Sy");
        Temas d5c4 = new Temas("BIRDS OF A FEATHER", "https://youtu.be/V9PVRfjEBTI?si=S5gSQUmF41yqaPQ0");
        Temas d5c5 = new Temas("WILDFLOWER", "https://youtu.be/l08Zw-RY__Q?si=SkG9jfLnp7V3hDQC");
        Temas d5c6 = new Temas("THE GREATEST", "https://youtu.be/WkdQhfDRBKs?si=Y4DeHGnTcEWBrauz");
        Temas d5c7 = new Temas("L’AMOUR DE MA VIE", "https://youtu.be/am5FI9DkO80?si=50MAfbId_J4ozsJJ");
        Temas d5c8 = new Temas("THE DINER", "https://youtu.be/gDVw1l6QDOg?si=ed1WdFc6SkUpRbAz");
        Temas d5c9 = new Temas("BITTERSUITE", "https://youtu.be/LmVw3u3SxoA?si=gEJbfrrKSFC27WcM");
        Temas d5c10 = new Temas("BLUE", "https://youtu.be/_IjWFq1c5M4?si=0gNgkEShpCE9M6Pc");
        disco5.Add(d5c1);
        disco5.Add(d5c2);
        disco5.Add(d5c3);
        disco5.Add(d5c4);
        disco5.Add(d5c5);
        disco5.Add(d5c6);
        disco5.Add(d5c7);
        disco5.Add(d5c8);
        disco5.Add(d5c9);
        disco5.Add(d5c10);

        List<Temas> disco6 = new List<Temas>();
        Temas d6c1 = new Temas("Angel Numbers / Ten Toes", "https://youtu.be/2vFU8u1YiX4?si=WMcPDoLAnZE-tyy_");
        Temas d6c2 = new Temas("Sensational (feat. Davido & Lojay)", "https://youtu.be/k_aixXMK068?si=tusv_cccv6N6zz8z");
        Temas d6c3 = new Temas("Press Me", "https://youtu.be/IndejLUyY-0?si=jpIDeYOK4ptM93JC");
        Temas d6c4 = new Temas("That’s On You", "https://youtu.be/w2v8JxLGJPk?si=jjIq6RrqE1XiXzbV");
        Temas d6c5 = new Temas("Feel Something", "https://youtu.be/HinZUZ05eXo?si=SYgsHzMrTs20ah1J");
        Temas d6c6 = new Temas("Best Ever", "https://youtu.be/rTk0Bjvvq1U?si=IWDwTdmlixmRPmLj");
        Temas d6c7 = new Temas("Messed Up", "https://youtu.be/k0O0_xJ1D0M?si=zIi4NHFG6p-pfwKU");
        Temas d6c8 = new Temas("No One Else", "");
        Temas d6c9 = new Temas("Midnight Freak", "https://youtu.be/Pf4YaBi7JrA?si=j5Pf06DG2InxeGoT");
        Temas d6c10 = new Temas("Make Up Your Mind", "https://youtu.be/ESEDgW8Tvjc?si=KZw6yG5kqK7x3ltB");
        disco6.Add(d6c1);
        disco6.Add(d6c2);
        disco6.Add(d6c3);
        disco6.Add(d6c4);
        disco6.Add(d6c5);
        disco6.Add(d6c6);
        disco6.Add(d6c7);
        disco6.Add(d6c8);
        disco6.Add(d6c9);
        disco6.Add(d6c10);
    }


}