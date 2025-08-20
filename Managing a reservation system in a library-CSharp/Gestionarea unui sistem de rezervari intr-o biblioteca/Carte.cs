namespace Gestionarea_unui_sistem_de_rezervari_intr_o_biblioteca;

public abstract class Carte
{
    public string Titlu { get;private set; }
    public string Autor { get;private set; }
    public int AnulPublicarii { get;private set; }
    public int NumarCopii { get;private set; }
    public List<Rezervare> Rezervari { get; private set; } = new List<Rezervare>();

    public Carte(string titlu, string autor, int anulPublicarii, int numarCopii)
    {
        Titlu = titlu;
        Autor = autor;
        AnulPublicarii = anulPublicarii;
        NumarCopii = numarCopii;
    }

    public void AddRezervari(Rezervare rezervare)
    {
        if (Validare(rezervare))
        {
            Console.WriteLine("Rezervarea a fost adaugata cu succes:");
            Rezervari.Add(rezervare);
        }
        else
        {
            Console.WriteLine("Rezervarea nu a fost adaugata cu succes:");
        }
    }
    
    public int NumarCopiiRezervare()
    {
        var total = 0;
        foreach (var rezervare in Rezervari)
        {
            total += rezervare.NumarCopii;
        }

        return total;
    }
 
    
    

    public abstract bool Validare(Rezervare rezervare);
    public abstract decimal CalculeazaPret(Rezervare rezervare);



}