namespace Gestionarea_unui_sistem_de_rezervari_intr_o_biblioteca;

public class Biblioteca
{
    public List<Carte> Carti{get;private set;}=new List<Carte>();

    public void AddCarte(Carte carte)
    {
        Carti.Add(carte);
    }

    public void AfisareRezervariCarte(string titlu)
    {
        var carte=Carti.Find(z => z.Titlu == titlu);
        if (carte != null)
        {
            Console.WriteLine($"Rezervarile pentru cartea:{carte.Titlu}");
            foreach (var rezervare in carte.Rezervari)
            {
                decimal pret = carte.CalculeazaPret(rezervare);
                Console.WriteLine($"{rezervare.Email} are {rezervare.NumarCopii} copii ,pret:{pret}");

            }
        }
        else
        {
            Console.WriteLine("Cartea este indisponibila");
            
        }
        
        
    }

    public void AfisareCopiiDisponibile(string Titlu)
    {
        var carte = Carti.Find(z => z.Titlu == Titlu);
        if (carte != null)
        {
            var copiidisponibile = carte.NumarCopii - carte.NumarCopiiRezervare();
            Console.WriteLine($"Numarul de copii disponibile este:{copiidisponibile}");
        }
        
    }
    
    
    
}