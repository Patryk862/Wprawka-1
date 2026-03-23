namespace WebApplication1.Models;

public class KsiazkaAutor
{
    public int KsiazkaId { get; set; }
    public Ksiazka Ksiazka { get; set; }

    public int AutorId { get; set; }
    public Autor Autor { get; set; }
}