namespace GestionareRezervariHoteluri;

public class CameraDeluxe : Camera
{
    private const int LimitaPersoane = 4;

    public CameraDeluxe(string tipCamera, int capacitateMaxima) : base(tipCamera, capacitateMaxima) { }

    public override bool Validare(Rezervare rezervare)
    {
        return rezervare.NumarPersoane<=LimitaPersoane;
    }

    public override decimal CalculeazaPret(Rezervare rezervare)
    {
        return rezervare.NumarNoptii * 500 + rezervare.NumarPersoane * 100 + 150;
    }
}