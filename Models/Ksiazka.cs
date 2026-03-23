using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Ksiazka
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Tytul { get; set; }

    // Relacja 1:N (Klucz obcy do Wydawnictwa)
    public int WydawnictwoId { get; set; }
    public Wydawnictwo Wydawnictwo { get; set; }

    // Relacja N:M
    public ICollection<KsiazkaAutor> KsiazkaAutorzy { get; set; } = new List<KsiazkaAutor>();
}