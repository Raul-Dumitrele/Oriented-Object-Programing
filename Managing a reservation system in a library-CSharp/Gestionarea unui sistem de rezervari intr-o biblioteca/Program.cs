using System;
using Gestionarea_unui_sistem_de_rezervari_intr_o_biblioteca;

class Program
{
    static void Main()
    {
        var biblioteca = new Biblioteca();
        var cartePopulara = new CartePopulara("HarapAlb", "Ion Creanga", 1900, 30);
        var carteRara = new CarteRara("Analiza Matematica", "Doru Paunescu", 2020, 10);
        
        biblioteca.AddCarte(cartePopulara);
        biblioteca.AddCarte(carteRara);
        
        cartePopulara.AddRezervari(new Rezervare("em1@gmail.com",2));
        carteRara.AddRezervari(new Rezervare("em2@gmail.com",2));
        
        biblioteca.AfisareRezervariCarte("HarapAlb");
        biblioteca.AfisareRezervariCarte("Analiza Matematica");
        
        biblioteca.AfisareCopiiDisponibile("HarapAlb");
        biblioteca.AfisareCopiiDisponibile("Analiza Matematica");
        
        
    }
    
}