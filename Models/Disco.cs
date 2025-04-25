namespace TРОЗ.Models;

public class Disco
{
    public string titulo { get; private set; }

    public string artista { get; private set; }
    public string productor { get; private set; }
    public string genero { get; private set; }
    public DateTime FechaLanzamiento { get; private set; }
    public List<Temas> temas { get; private set; }
    public int id { get; private set; }
    public string foto { get; private set; }

    public Disco(string artista, string productor, string genero, List <Temas> temas, int id, string foto)
    {
        this.artista = artista; 
        this.productor = productor;
        this.genero = genero;
        this.temas = temas;
        this.id = id;
        this.foto = foto;
    }
}