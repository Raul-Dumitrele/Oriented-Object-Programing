namespace Sistem_de_Management_al_Transporturilor_Globale;

public class Plane : Vehicle
{
    public Plane(string iD, double capacity) : base(iD, capacity)
    {
        Type = "Plane";
    }

    public override double CalculatedFuelEfficency(double distance)
    {
        return distance * 1.2;
    }
}