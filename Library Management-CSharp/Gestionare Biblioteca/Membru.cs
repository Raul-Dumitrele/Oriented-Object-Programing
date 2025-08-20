namespace Gestionare_Biblioteca;

public class Membru
{
    public int Id { get; set; }  // Cheie primară pentru EF Core
    public string Nume { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public List<Imprumut> Imprumuturi { get; set; } = new List<Imprumut>();

    // Constructor fără parametri necesar pentru EF Core
    public Membru() { }

    public Membru(string nume, string email)
    {
        Nume = nume;
        Email = email;
        Imprumuturi = new List<Imprumut>();
    }
}