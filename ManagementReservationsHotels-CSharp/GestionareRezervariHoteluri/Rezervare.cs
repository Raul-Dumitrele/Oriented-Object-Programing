namespace GestionareRezervariHoteluri;

public class Rezervare
{
    public string NumeClient{ get;private set; }
    public string Telefon{get;private set;}
    public int NumarPersoane {get;private set;}
    public int NumarNoptii {get;private set;}
    public string TipCamera {get;private set;}

    public Rezervare(string numeClient, string telefon,string tipCamera, int numarPersoane, int numarNoptii)
    {
        NumeClient = numeClient;
        Telefon = telefon;
        NumarPersoane = numarPersoane;
        NumarNoptii = numarNoptii;
        TipCamera = tipCamera;
    }
    
    
    
    
}