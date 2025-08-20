namespace Sistem_de_Management_al_Transporturilor_Globale;

public class Train : Vehicle
{
    public Train(string iD, double capacity) : base(iD, capacity)
    {
        Type = "Train";
    }

    public override double CalculatedFuelEfficency(double distance)
    {
        return distance * 0.2;
    }
}