namespace TРОЗ.Models;

public class GestorDiscos
{
    public static Dictionary<int, Disco> Discos { get; private set; }

    public static void InicializarGrupo()
    {
        Discos = new Dictionary<int, Disco>();
        
        
    }


}