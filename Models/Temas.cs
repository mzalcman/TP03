namespace TРОЗ.Models;

public class Temas
{
    public string nombre { get; private set; }
    public string video { get; private set; }

    public Temas(string nombre, string video)
    {
        this.nombre = nombre;
        this.video = video;
    }
}