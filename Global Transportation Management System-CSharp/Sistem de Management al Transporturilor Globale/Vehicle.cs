namespace Sistem_de_Management_al_Transporturilor_Globale;

public abstract class Vehicle
{
    public string ID{ get; set; }
    public string Type { get;protected set; }
    public double Capacity { get; set; }
    public bool Status{ get; set; }

    public Vehicle(string iD , double capacity)
    {
        ID = iD;
        Capacity = capacity;
        Status = true;
    }
    
    public abstract double CalculatedFuelEfficency(double distance);

    public override string ToString()
    {
        return $"{Type} [ID: {ID}, Capacity: {Capacity} tons, Available: {Status}]";

    }
    
    
    
    
}