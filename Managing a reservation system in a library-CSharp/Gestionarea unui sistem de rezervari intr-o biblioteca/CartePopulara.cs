namespace Gestionarea_unui_sistem_de_rezervari_intr_o_biblioteca;

public class CartePopulara:Carte
{
    private const int LimitaCopii = 3;
    
    public CartePopulara(string titlu, string autor, int anulPublicarii, int numarCopii)
         : base(titlu, autor, anulPublicarii, numarCopii) {}

    public override bool Validare(Rezervare rezervare)
    {
        return rezervare.NumarCopii<=LimitaCopii;
    }

    public override decimal CalculeazaPret(Rezervare rezervare)
    {
        return 50*rezervare.NumarCopii;
    }
}