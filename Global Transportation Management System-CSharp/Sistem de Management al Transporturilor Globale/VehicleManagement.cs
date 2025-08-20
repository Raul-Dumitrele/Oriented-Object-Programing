namespace Sistem_de_Management_al_Transporturilor_Globale;

public class VehicleManagement
{
    private List<Vehicle> Vehicles { get; set; }

    public VehicleManagement()
    {
        Vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
    }

    public Vehicle GetAvailableVehicle(double requiredCapacity)
    {
        return Vehicles.FirstOrDefault(v=>v.Status&&v.Capacity>=requiredCapacity);
        //este o metodă din LINQ care gaseste primul element dintr-o colectie care respecta o condiție specificata.
    }

    public void ListVehicles()
    {
        foreach (var vehicle in Vehicles)
        {
            Console.WriteLine(vehicle);
            
        }
    }
    
    
    
    
}