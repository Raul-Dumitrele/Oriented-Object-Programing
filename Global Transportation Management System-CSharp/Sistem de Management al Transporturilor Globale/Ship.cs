namespace Sistem_de_Management_al_Transporturilor_Globale;

public class Ship : Vehicle
{
    public Ship(string iD, double capacity) : base(iD, capacity)
    {
        Type = "Ship";
    }

    public override double CalculatedFuelEfficency(double distance)
    {
        return distance * 0.5;
    }
}