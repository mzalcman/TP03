namespace TРОЗ.Models;

public class GestorDiscos
{
    public static Dictionary<int, Disco> Discos { get; private set; }

    public static void InicializarDiscos()
    {
        
        
    }

    private static void CargarDiscos()
    {
        Discos = new Dictionary<int, Disco>();
        List<Temas> disco1 = new List<Temas>();
        Temas d1 = new Temas("we can't be friends", "https://youtu.be/KNtJGQkC-WI?feature=shared");
        Temas d2 = new Temas("yes, and?", "https://youtu.be/eB6txyhHFG4?feature=shared");
        Temas d3= new Temas("Problem", "https://youtu.be/iS1g8G_njx8?feature=shared");
        Temas d4 = new Temas("7 rings", "https://youtu.be/QYh6mYIJG2Y?feature=shared");
        Temas d5 = new Temas("Break Free", "https://youtu.be/L8eRzOYhLuw?feature=shared");
        Temas d6 = new Temas("Into You", "https://youtu.be/1ekZEVeXwek?feature=shared");
        Temas d7 = new Temas("Focus", "https://youtu.be/lf_wVfwpfp8?feature=shared");
        Temas d8 = new Temas("The Weeknd", "https://youtu.be/g5qU7p7yOY8?feature=shared");
        Temas d9 = new Temas("Thank u, next", "https://youtu.be/gl1aHhXnN1k?feature=shared");
        Temas d10 = new Temas("Positions", "https://youtu.be/tcYodQoapMg?feature=shared");
        disco1.Add(d1);
        disco1.Add(d2);
        disco1.Add(d3);
        disco1.Add(d4);
        disco1.Add(d5);
        disco1.Add(d6);
        disco1.Add(d7);
        disco1.Add(d8);
        disco1.Add(d9);
        disco1.Add(d10);
    }


}