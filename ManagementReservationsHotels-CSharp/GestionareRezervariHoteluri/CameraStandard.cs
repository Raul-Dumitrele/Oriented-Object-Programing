namespace GestionareRezervariHoteluri;

public class CameraStandard : Camera
{
    private const int LimitaPersoane = 2;

    public CameraStandard(string tipCamera, int capacitateMaxima) : base(tipCamera, capacitateMaxima) {}

    public override bool Validare(Rezervare rezervare)
    {
        return rezervare.NumarPersoane<=LimitaPersoane;
    }

    public override decimal CalculeazaPret(Rezervare rezervare)
    {
        return rezervare.NumarPersoane*50+rezervare.NumarNoptii*200;
    }
}