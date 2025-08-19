namespace Sistem_de_gestionare_a_Bancilor;

public abstract class Cont
{
    public int NumarCont { get; set; }
    public double Sold { get; protected set; }

    public Cont(int numarCont, double soldInitial)
    {
        NumarCont = numarCont;
        Sold = soldInitial;
    }
    
    public abstract void Depunere(double suma);
    public abstract bool Retragere(double suma);
    
}