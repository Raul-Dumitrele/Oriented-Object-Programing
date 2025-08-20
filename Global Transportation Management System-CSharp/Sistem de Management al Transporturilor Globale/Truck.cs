namespace Sistem_de_Management_al_Transporturilor_Globale;

public class Truck : Vehicle
{
    public Truck(string id, double capacity) : base(id, capacity)
    {
        Type = "Truck";
    }

    public override double CalculatedFuelEfficency(double distance)
    {
        return distance*0.3;        //exemplu de consum de 0,3litri/km
    }
}


