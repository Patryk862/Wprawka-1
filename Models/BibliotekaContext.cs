using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class BibliotekaContext : DbContext
{
    public BibliotekaContext(DbContextOptions<BibliotekaContext> options) : base(options) { }

    public DbSet<Wydawnictwo> Wydawnictwa { get; set; }
    public DbSet<Ksiazka> Ksiazki { get; set; }
    public DbSet<Autor> Autorzy { get; set; }
    public DbSet<KsiazkaAutor> KsiazkaAutorzy { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Ustawienie złożonego klucza dla tabeli pośredniej, używając polskich nazw ID
        modelBuilder.Entity<KsiazkaAutor>()
            .HasKey(ka => new { ka.KsiazkaId, ka.AutorId });
    }
}