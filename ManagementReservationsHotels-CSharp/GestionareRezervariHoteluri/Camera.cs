namespace GestionareRezervariHoteluri;

public abstract class Camera
{
    public string TipCamera { get; private set; }
    public int CapacitateMaxima { get; private set; }

    public Camera(string tipCamera, int capacitateMaxima)
    {
        TipCamera = tipCamera;
        CapacitateMaxima = capacitateMaxima;
    }
    
    public abstract decimal CalculeazaPret(Rezervare rezervare);

    public abstract bool Validare(Rezervare rezervare);
}