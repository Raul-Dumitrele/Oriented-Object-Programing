using System.Reflection.Metadata.Ecma335;

namespace GestionareRezervariHoteluri;

public class Hotel
{
    public string HotelNume { get;private set; }
    public string Locatie { get; private set; }
    public List<Camera> Camere{get;private set;} = new List<Camera>();
    public List<Rezervare> Rezervari { get; private set; } = new List<Rezervare>();


    public Hotel(string hotelNume, string locatie)
    {
        HotelNume = hotelNume;
        Locatie = locatie;
    }

    public void AdaugaCamera(Camera camera)
    {
        Camere.Add(camera);
    }

    public void AdaugaRezervare(Rezervare rezervare)
    {  
        var camera=Camere.Find(c=>c.TipCamera==rezervare.TipCamera);
        if (camera != null && camera.Validare(rezervare))
        {
            Rezervari.Add(rezervare);
            Console.WriteLine("Rezervarea a fost adăugată cu succes!");
        }
        else
        {
            Console.WriteLine("Rezervarea nu a fost acceptată. Verificați capacitatea camerei.");
        }
    }

    public void AfiseazaRezervariCamere( )
    {
        
        Console.WriteLine($"Rezervarile pentru hotelul: {HotelNume}-Locatie:{Locatie}");
        foreach (var rezervare in Rezervari)
        {
            
            var camera = Camere.Find(c => c.TipCamera == rezervare.TipCamera);    
            decimal pret = camera.CalculeazaPret(rezervare);
            Console.WriteLine($"Client: {rezervare.NumeClient}, Telefon: {rezervare.Telefon}, Tip Camera: {rezervare.TipCamera}" +
                              $" Preț: {pret}");            
        }
        
    }
    public void AfiseazaNumarTotalPersoane()
    {
        int totalPersoane = 0;
        foreach (var rezervare in Rezervari)
        {
            totalPersoane += rezervare.NumarPersoane;
        }
        Console.WriteLine($"Numărul total de persoane cazate în hotel: {totalPersoane}");
    }
 
}