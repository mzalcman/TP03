namespace TРОЗ.Models;

public class GestorDiscos
{
    public static Dictionary<int, Disco> Discos { get; private set; }

    public static void InicializarDiscos()
    {
        Discos = new Dictionary<int, Disco>();
        CargarDiscos();
        //Hacer que recorra el diccionarioa compararndo con el nombre (que no sea con el contains key) y si termina y no hay igualdad lo agregue


    }
    private static void agregarDisco(string titulo, string artista, string productor, string genero, List <Temas> temas, int id, string foto, DateTime fechaLanzamiento)
    {
        bool puedoAgregarlo = true;
        foreach(int clave in Discos.Keys)
        {
            if(titulo == Discos[clave].titulo)
            {
                puedoAgregarlo = false;
            }
        }
        if(puedoAgregarlo)
        {

        }
    }
    private static void CargarDiscos()
    {
        List<Temas> temasDelDisco1 = new List<Temas>();
        Temas temas1cancion1 = new Temas("we can't be friends", "https://youtu.be/KNtJGQkC-WI?feature=shared");
        Temas temas1cancion2 = new Temas("yes, and?", "https://youtu.be/eB6txyhHFG4?feature=shared");
        Temas temas1cancion3 = new Temas("Problem", "https://youtu.be/iS1g8G_njx8?feature=shared");
        Temas temas1cancion4 = new Temas("7 rings", "https://youtu.be/QYh6mYIJG2Y?feature=shared");
        Temas temas1cancion5 = new Temas("Break Free", "https://youtu.be/L8eRzOYhLuw?feature=shared");
        Temas temas1cancion6 = new Temas("Into You", "https://youtu.be/1ekZEVeXwek?feature=shared");
        Temas temas1cancion7 = new Temas("Focus", "https://youtu.be/lf_wVfwpfp8?feature=shared");
        Temas temas1cancion8 = new Temas("The Weeknd", "https://youtu.be/g5qU7p7yOY8?feature=shared");
        Temas temas1cancion9 = new Temas("Thank u, next", "https://youtu.be/gl1aHhXnN1k?feature=shared");
        Temas temas1cancion10 = new Temas("Positions", "https://youtu.be/tcYodQoapMg?feature=shared");
        temasDelDisco1.Add(temas1cancion1);
        temasDelDisco1.Add(temas1cancion2);
        temasDelDisco1.Add(temas1cancion3);
        temasDelDisco1.Add(temas1cancion4);
        temasDelDisco1.Add(temas1cancion5);
        temasDelDisco1.Add(temas1cancion6);
        temasDelDisco1.Add(temas1cancion7);
        temasDelDisco1.Add(temas1cancion8);
        temasDelDisco1.Add(temas1cancion9);
        temasDelDisco1.Add(temas1cancion10);
        DateTime fechaLD1 = new DateTime(2024,03,08);
        agregarDisco("Eternal Sunshine","Ariana Grande", "Max Martin", "Pop", temasDelDisco1, 0, "Ariana.jpeg", fechaLD1);


        List<Temas> temasDelDisco2 = new List<Temas>();
        Temas temas2cancion1 = new Temas("Ameriican Requiem", "https://youtu.be/vp3BSjJdyow?feature=shared");
        Temas temas2cancion2 = new Temas("Blackbiird", "https://youtu.be/xhempeEjGUA?feature=shared");
        Temas temas2cancion3 = new Temas("16 Carriages", "https://youtu.be/hhKNjTb6U1Y?feature=shared");
        Temas temas2cancion4 = new Temas("Protector", "https://youtu.be/f4xrblI8Tvw?feature=shared");
        Temas temas2cancion5 = new Temas("My rose", "https://youtu.be/VWfSNezeQCc?feature=shared");
        Temas temas2cancion6 = new Temas("Bodyguard", "https://youtu.be/7HV_Rv858YM?feature=shared");
        Temas temas2cancion7 = new Temas("Jolene", "https://youtu.be/x9XHMK3nWr4?feature=shared");
        Temas temas2cancion8 = new Temas("Smoke hour II", "https://youtu.be/8FE9z3btl9Q?feature=shared");
        Temas temas2cancion9 = new Temas("Just for fun", "https://youtu.be/vSZCl3Qs9rA?feature=shared");
        Temas temas2cancion10 = new Temas("Flamenco", "https://youtu.be/SKQcy3JDrAQ?feature=shared");
        temasDelDisco2.Add(temas2cancion1);
        temasDelDisco2.Add(temas2cancion2);
        temasDelDisco2.Add(temas2cancion3);
        temasDelDisco2.Add(temas2cancion4);
        temasDelDisco2.Add(temas2cancion5);
        temasDelDisco2.Add(temas2cancion6);
        temasDelDisco2.Add(temas2cancion7);
        temasDelDisco2.Add(temas2cancion8);
        temasDelDisco2.Add(temas2cancion9);
        temasDelDisco2.Add(temas2cancion10);
        DateTime fechaLD2 = new DateTime(2024,03,29);
        agregarDisco("Cowboy Carter", "Beyoncé", "Pharrell Williams", "Country", temasDelDisco2, 1, "Beyonce.jpeg", fechaLD2);


        List<Temas> temasDelDisco3 = new List<Temas>();
        Temas temas3cancion1 = new Temas("Paid", "https://youtu.be/oG1xb5KOcN4?feature=shared");
        Temas temas3cancion2 = new Temas("Keys to my life", "https://youtu.be/kX3ivxNp9PY?feature=shared");
        Temas temas3cancion3 = new Temas("Back to me", "https://youtu.be/MiTIhSb-b2k?feature=shared");
        Temas temas3cancion4 = new Temas("Do it", "https://youtu.be/G0hxhn7-Hps?feature=shared");
        Temas temas3cancion5 = new Temas("Burn", "https://youtu.be/oAbX14IadBo?feature=shared");
        Temas temas3cancion6 = new Temas("Fuck sumn", "https://youtu.be/xd2SEKy6HIM?feature=shared");
        Temas temas3cancion7 = new Temas("Paperwork", "https://youtu.be/FmrXYkfv2eU?feature=shared");
        Temas temas3cancion8 = new Temas("Hoodrat", "https://youtu.be/eHHwQMxvVOU?feature=shared");
        Temas temas3cancion9 = new Temas("Problematic", "https://youtu.be/xcprkHw4cd8?feature=shared");
        Temas temas3cancion10 = new Temas("King", "https://youtu.be/g6vAQpxo35g?feature=shared");
        temasDelDisco3.Add(temas3cancion1);
        temasDelDisco3.Add(temas3cancion2);
        temasDelDisco3.Add(temas3cancion3);
        temasDelDisco3.Add(temas3cancion4);
        temasDelDisco3.Add(temas3cancion5);
        temasDelDisco3.Add(temas3cancion6);
        temasDelDisco3.Add(temas3cancion7);
        temasDelDisco3.Add(temas3cancion8);
        temasDelDisco3.Add(temas3cancion9);
        temasDelDisco3.Add(temas3cancion10);
        DateTime fechaLD3 = new DateTime(2024,02,10);
        agregarDisco("Vultures 1", "Kanye West", "Ty Dolla $ign", "Hip-Hop", temasDelDisco3, 2, "Kanye.jpeg", fechaLD3);


        List<Temas> temasDelDisco4 = new List<Temas>();
        Temas temas4cancion1 = new Temas("End Of An Era", "https://youtu.be/apSZ77414bA?si=1P_LwGvHcgkq84Ll");
        Temas temas4cancion2 = new Temas("Houdini", "https://youtu.be/cCfPDrRQp9k?si=IQrSv_08R14u6pjH");
        Temas temas4cancion3 = new Temas("Training Season", "https://youtu.be/n0GXk_T2zs8?si=czRgp9Ac0Plqzy3F");
        Temas temas4cancion4 = new Temas("These Walls", "https://youtu.be/txxkp-mf1Eo?si=OuQsZJwKWU2LEGkB");
        Temas temas4cancion5 = new Temas("Whatcha Doing", "https://youtu.be/tZ0B6L4SiBQ?si=J36XV01AaSw0oh_x");
        Temas temas4cancion6 = new Temas("French Exit", "https://youtu.be/c-sspyeKFjI?si=pcZX7F8gbNBh8KfS");
        Temas temas4cancion7 = new Temas("Illusion", "https://youtu.be/a9cyG_yfh1k?si=vB8ame4v5ZNQoQk9");
        Temas temas4cancion8 = new Temas("Falling Forever", "https://youtu.be/IGM-B6CaP0c?si=iUoSsTwBoOyGjZSA");
        Temas temas4cancion9 = new Temas("Anything For Love", "https://youtu.be/0dF1dPLF9cQ?si=LkAEU80Jqwrf1dCf");
        Temas temas4cancion10 = new Temas("Happy For You", "https://youtu.be/KKypB3YEPe0?si=QJZIF2NXQCyDNCLU");
        temasDelDisco4.Add(temas4cancion1);
        temasDelDisco4.Add(temas4cancion2);
        temasDelDisco4.Add(temas4cancion3);
        temasDelDisco4.Add(temas4cancion4);
        temasDelDisco4.Add(temas4cancion5);
        temasDelDisco4.Add(temas4cancion6);
        temasDelDisco4.Add(temas4cancion7);
        temasDelDisco4.Add(temas4cancion8);
        temasDelDisco4.Add(temas4cancion9);
        temasDelDisco4.Add(temas4cancion10);
        DateTime fechaLD4 = new DateTime(2024,05,17);
        agregarDisco("Under the Stairs", "Zayn", "Dave Cobb", "Pop", temasDelDisco4, 3, "Zayn.jpeg", fechaLD4);


        List<Temas> temasDelDisco5 = new List<Temas>();
        Temas temas5cancion1 = new Temas("SKINNY", "https://youtu.be/g6YSdMnCOCU?si=d_PV8vgnMFJN5NYL");
        Temas temas5cancion2 = new Temas("LUNCH", "https://youtu.be/MB3VkzPdgLA?si=QFNiCp-Iz_16DpRs");
        Temas temas5cancion3 = new Temas("CHIHIRO", "https://youtu.be/BY_XwvKogC8?si=LpXCDsxOe7OqD4Sy");
        Temas temas5cancion4 = new Temas("BIRDS OF A FEATHER", "https://youtu.be/V9PVRfjEBTI?si=S5gSQUmF41yqaPQ0");
        Temas temas5cancion5 = new Temas("WILDFLOWER", "https://youtu.be/l08Zw-RY__Q?si=SkG9jfLnp7V3hDQC");
        Temas temas5cancion6 = new Temas("THE GREATEST", "https://youtu.be/WkdQhfDRBKs?si=Y4DeHGnTcEWBrauz");
        Temas temas5cancion7 = new Temas("L’AMOUR DE MA VIE", "https://youtu.be/am5FI9DkO80?si=50MAfbId_J4ozsJJ");
        Temas temas5cancion8 = new Temas("THE DINER", "https://youtu.be/gDVw1l6QDOg?si=ed1WdFc6SkUpRbAz");
        Temas temas5cancion9 = new Temas("BITTERSUITE", "https://youtu.be/LmVw3u3SxoA?si=gEJbfrrKSFC27WcM");
        Temas temas5cancion10 = new Temas("BLUE", "https://youtu.be/_IjWFq1c5M4?si=0gNgkEShpCE9M6Pc");
        temasDelDisco5.Add(temas5cancion1);
        temasDelDisco5.Add(temas5cancion2);
        temasDelDisco5.Add(temas5cancion3);
        temasDelDisco5.Add(temas5cancion4);
        temasDelDisco5.Add(temas5cancion5);
        temasDelDisco5.Add(temas5cancion6);
        temasDelDisco5.Add(temas5cancion7);
        temasDelDisco5.Add(temas5cancion8);
        temasDelDisco5.Add(temas5cancion9);
        temasDelDisco5.Add(temas5cancion10);
        DateTime fechaLD5 = new DateTime(2024,05,03);
        agregarDisco("Radical Optimism", "Dua Lipa", "Kevin Parker", "Pop", temasDelDisco5, 4, "DuaLipa.jpeg", fechaLD5);


        List<Temas> temasDelDisco6 = new List<Temas>();
        Temas temas6cancion1 = new Temas("Angel Numbers / Ten Toes", "https://youtu.be/2vFU8u1YiX4?si=WMcPDoLAnZE-tyy_");
        Temas temas6cancion2 = new Temas("Sensational (feat. Davido & Lojay)", "https://youtu.be/k_aixXMK068?si=tusv_cccv6N6zz8z");
        Temas temas6cancion3 = new Temas("Press Me", "https://youtu.be/IndejLUyY-0?si=jpIDeYOK4ptM93JC");
        Temas temas6cancion4 = new Temas("That’s On You", "https://youtu.be/w2v8JxLGJPk?si=jjIq6RrqE1XiXzbV");
        Temas temas6cancion5 = new Temas("Feel Something", "https://youtu.be/HinZUZ05eXo?si=SYgsHzMrTs20ah1J");
        Temas temas6cancion6 = new Temas("Best Ever", "https://youtu.be/rTk0Bjvvq1U?si=IWDwTdmlixmRPmLj");
        Temas temas6cancion7 = new Temas("Messed Up", "https://youtu.be/k0O0_xJ1D0M?si=zIi4NHFG6p-pfwKU");
        Temas temas6cancion8 = new Temas("No One Else", "");
        Temas temas6cancion9 = new Temas("Midnight Freak", "https://youtu.be/Pf4YaBi7JrA?si=j5Pf06DG2InxeGoT");
        Temas temas6cancion10 = new Temas("Make Up Your Mind", "https://youtu.be/ESEDgW8Tvjc?si=KZw6yG5kqK7x3ltB");
        temasDelDisco6.Add(temas6cancion1);
        temasDelDisco6.Add(temas6cancion2);
        temasDelDisco6.Add(temas6cancion3);
        temasDelDisco6.Add(temas6cancion4);
        temasDelDisco6.Add(temas6cancion5);
        temasDelDisco6.Add(temas6cancion6);
        temasDelDisco6.Add(temas6cancion7);
        temasDelDisco6.Add(temas6cancion8);
        temasDelDisco6.Add(temas6cancion9);
        temasDelDisco6.Add(temas6cancion10);
        DateTime fechaLD6 = new DateTime(2024,05,17);
        agregarDisco("Hit Me Hard and Soft", "Billie Eilish", "Finneas O’Connell", "Alt-pop", temasDelDisco6, 5, "BillieEilish.jpeg", fechaLD6);
    }


}