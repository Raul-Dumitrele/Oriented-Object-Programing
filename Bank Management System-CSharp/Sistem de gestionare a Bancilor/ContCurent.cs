namespace Sistem_de_gestionare_a_Bancilor;

public class ContCurent : Cont
{
    public ContCurent(int numarCont, double soldInitial) : base(numarCont, soldInitial) {}

    public override void Depunere(double suma)
    {
        Sold += suma;
        Console.WriteLine($"Depunere:{suma} lei,Soldul actualizat: {Sold} lei");
    }

    public override bool Retragere(double suma)
    {
        if (Sold > suma)
        {
            Sold -= suma;
            Console.WriteLine($"Retragere:{suma} lei,Soldul actualizat{Sold} lei");
            return true;

        }
        else
        {
            Console.WriteLine("Fonduri insuficiente!");
            return false;
        }
    }
}
