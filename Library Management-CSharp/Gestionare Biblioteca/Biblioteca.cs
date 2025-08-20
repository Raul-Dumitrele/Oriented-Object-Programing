namespace Gestionare_Biblioteca
{
    public class Biblioteca
    {
        private readonly BibliotecaDbContext _context;

        public Biblioteca(BibliotecaDbContext context)
        {
            _context = context;
        }

        public void AdaugaCarte(Carte carte)
        {
            _context.Carti.Add(carte);
            _context.SaveChanges();
            Console.WriteLine($"Cartea '{carte.Titlu}' a fost adăugată.");
        }

        public void AdaugaMembru(Membru membru)
        {
            _context.Membri.Add(membru);
            _context.SaveChanges();
            Console.WriteLine($"Membrul '{membru.Nume}' a fost adăugat.");
        }

        public void AfisareCartiDisponibile()
        {
            var carti = _context.Carti
                .Where(c => c.Disponibil)
                .ToList();

            Console.WriteLine("Cărți disponibile:");
            if (carti.Count > 0)
            {
                foreach (var carte in carti)
                    Console.WriteLine($"- {carte.Titlu} de {carte.Autor}");
            }
            else
            {
                Console.WriteLine("Nu există cărți disponibile.");
            }
        }

        public void InregistrareImprumut(Carte carte, Membru membru)
        {
            if (carte.Disponibil)
            {
                var imprumut = new Imprumut
                {
                    CarteId = carte.Id,
                    MembruId = membru.Id,
                    DataImprumut = DateTime.Now
                };

                carte.Disponibil = false;
                _context.Imprumuturi.Add(imprumut);
                _context.SaveChanges();
                Console.WriteLine($"Cartea '{carte.Titlu}' a fost împrumutată de {membru.Nume}.");
            }
            else
            {
                Console.WriteLine($"Cartea '{carte.Titlu}' nu este disponibilă!");
            }
        }

        public void ReturnareCarte(Carte carte)
        {
            var imprumut = _context.Imprumuturi
                .FirstOrDefault(i => i.CarteId == carte.Id && i.DataReturnare == null);

            if (imprumut != null)
            {
                imprumut.DataReturnare = DateTime.Now;
                carte.Disponibil = true;
                _context.SaveChanges();
                Console.WriteLine($"Cartea '{carte.Titlu}' a fost returnată.");
            }
            else
            {
                Console.WriteLine($"Cartea '{carte.Titlu}' nu a fost împrumutată sau nu a fost găsită.");
            }
        }
    }
}



/*
namespace Gestionare_Biblioteca;

public class Biblioteca
{
    public List<Carte> Carti { get; set; } = new List<Carte>();
    public List<Membru> Membri { get; set; } = new List<Membru>();
    public List<Imprumut> Imprumuturi { get; set; } = new List<Imprumut>();

    public void AdaugaCarte(Carte carte)
    {
        Carti.Add(carte);
    }

    public void AdaugaMembru(Membru membru)
    {
        Membri.Add(membru);
    }

    public Carte CarteCautataISBN(string isbn)
    {
        return Carti.Find(x => x.ISBN == isbn);
    }

    public void InregistrareImprumut(Carte carte, Membru membru)
    {
        if (carte.Disponibil)
        {
            Imprumut nouImprumut = new Imprumut(carte, membru, DateTime.Now);
            Imprumuturi.Add(nouImprumut);
            membru.Imprumuturi.Add(nouImprumut);
            carte.Disponibil = false;
            Console.WriteLine($"Cartea '{carte.Titlu}' a fost împrumutată de {membru.Nume}.");
        }
        else
        {
            Console.WriteLine("Cartea nu este disponibilă pentru împrumut!");
        }
    }

    public void ReturnareCarte(Carte carte)
    {
        var imprumut = Imprumuturi.Find(x => x.CarteImprumutata == carte && x.DataReturnare == null);
        if (imprumut != null)
        {
            imprumut.DataReturnare = DateTime.Now;
            carte.Disponibil = true;
            Console.WriteLine($"Cartea '{carte.Titlu}' a fost returnată.");
        }
        else
        {
            Console.WriteLine("Cartea nu a fost găsită în lista de împrumuturi active.");
        }
    }

    public void AfisareCartiDisponibile()
    {
        var cartiDisponibile = Carti.Where(x => x.Disponibil).ToList();
        if (cartiDisponibile.Count > 0)
        {
            Console.WriteLine("Cărțile disponibile:");
            foreach (var carte in cartiDisponibile)
            {
                Console.WriteLine($"- {carte.Titlu} de {carte.Autor}");
            }
        }
        else
        {
            Console.WriteLine("Nu există cărți disponibile.");
        }
    }
}








namespace Gestionare_Biblioteca;

public class Biblioteca
{
    public List<Carte> Carti = new List<Carte>();
    public List<Membru> Membri = new List<Membru>();
    public List<Imprumut> Imprumuturi = new List<Imprumut>();

    public void AdaugaCarte(Carte carte)
    {
        Carti.Add(carte);
    }

    public void AdaugaMembru(Membru membru)
    {
        Membri.Add(membru);
    }

    public Carte CarteCautataISBN(string isbn)
    {
        return Carti.Find(x => x.ISBN == isbn);
    }

    public void InregistrareImprumut(Carte carte, Membru membru)
    {
        if (carte.Disponibil)
        {
            Imprumut nouImprumut = new Imprumut(carte, membru, DateTime.Now);
            Imprumuturi.Add(nouImprumut);
            membru.Imprumuturi.Add(nouImprumut);
            carte.Disponibil = false;
            Console.WriteLine($"Cartea '{carte.Titlu}' a fost împrumutată de {membru.Nume}.");
        }
        else
        {
            Console.WriteLine("Cartea nu este disponibilă pentru împrumut!");
        }
    }

    public void ReturnareCarte(Carte carte)
    {
        var imprumut = Imprumuturi.Find(x => x.CarteImprumutata == carte && x.DataReturnare == null);
        if (imprumut != null)
        {
            imprumut.DataReturnare = DateTime.Now;
            carte.Disponibil = true;
            Console.WriteLine($"Cartea '{carte.Titlu}' a fost returnată.");
        }
        else
        {
            Console.WriteLine("Cartea nu a fost găsită în lista de împrumuturi active.");
        }
    }

    public void AfisareCartiDisponibile()
    {
        var cartiDisponibile = Carti.Where(x => x.Disponibil).ToList();
        if (cartiDisponibile.Count > 0)
        {
            Console.WriteLine("Cărțile disponibile:");
            foreach (var carte in cartiDisponibile)
            {
                Console.WriteLine($"- {carte.Titlu} de {carte.Autor}");
            }
        }
        else
        {
            Console.WriteLine("Nu există cărți disponibile.");
        }
    }
}

*/