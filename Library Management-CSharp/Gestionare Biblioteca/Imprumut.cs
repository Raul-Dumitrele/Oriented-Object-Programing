namespace Gestionare_Biblioteca;

public class Imprumut
{
    public int Id { get; set; }  // Cheie primară pentru EF Core
    public int CarteId { get; set; }  // Foreign Key
    public Carte CarteImprumutata { get; set; } = null!;
    
    public int MembruId { get; set; }  // Foreign Key
    public Membru ImprumutataDe { get; set; } = null!;
    
    public DateTime DataImprumut { get; set; }
    public DateTime? DataReturnare { get; set; }  // Nullable pentru returnare
    
    // Constructor fără parametri necesar pentru EF Core
    public Imprumut() { }

    public Imprumut(Carte carte, Membru membru, DateTime now)
    {
        CarteImprumutata = carte;
        MembruId = membru.Id;
        DataImprumut = DateTime.Now;
    }
}