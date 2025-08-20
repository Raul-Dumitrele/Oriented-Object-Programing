namespace Gestionare_Biblioteca;

public class Carte
{
    public int Id { get; set; }  // Cheie primară pentru EF Core
    public string Titlu { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public bool Disponibil { get; set; } = true;

    // Constructor fără parametri necesar pentru EF Core
    public Carte() { }

    public Carte(string titlu, string autor, string isbn)
    {
        Titlu = titlu;
        Autor = autor;
        ISBN = isbn;
        Disponibil = true;
    }
}