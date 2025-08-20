namespace Gestionarea_unui_sistem_de_rezervari_intr_o_biblioteca;

public class Rezervare
{
    public string Email { get;private set; }
    public int NumarCopii { get; private set; }

    public Rezervare(string email, int numarCopii)
    {
        Email = email;
        NumarCopii = numarCopii;
    }
    
    
    
}