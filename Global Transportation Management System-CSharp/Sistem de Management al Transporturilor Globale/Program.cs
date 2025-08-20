using System;
using System.Threading.Channels;
using Sistem_de_Management_al_Transporturilor_Globale;

class Program
{
    static void Main(string[] args)
    {
        VehicleManagement vehicleManager = new VehicleManagement();
        Route_Optimizer routeOptimizer = new Route_Optimizer();
        
        vehicleManager.AddVehicle(new Truck("TRK-01",20));
        vehicleManager.AddVehicle(new Truck("TRK-02",40));

        var routes = new List<Route>
        {
            new Route("Bucuresti", "Cluj", 450,null),
            new Route("Bucuresti", "Iasi", 400,null),
            new Route("Cluj", "Iasi", 300,null)
        };


        Console.WriteLine("Vehicles Available");
        vehicleManager.ListVehicles();
        
        var shortestRoute = routeOptimizer.FindShortestRoute(routes, "Bucuresti", "Cluj");
        if (shortestRoute != null)
        {
            Console.WriteLine($"Shortest Route: {shortestRoute}");
        }
        else
        {
            Console.WriteLine("No shortest route found.");
        }

        Console.WriteLine("\n\n");
        
        //VARIANTA CU WAYPOINTURI
        var route = new Route("Bucuresti", "Cluj", 450, new List<string> { "Pitesti", "Ramnicu Valcea" });

        // Afișează ruta inițială
        Console.WriteLine(route);

        // Adaugă un nou waypoint
        route.AddWaypoint("Deva");
        Console.WriteLine("After adding Deva:");
        Console.WriteLine(route);

        // Încercăm să adăugăm un waypoint duplicat
        route.AddWaypoint("Pitesti");

        // Afișează lista de waypoints
        route.DisplayWaypoints();

        // Elimină un waypoint
        route.RemoveWaypoint("Ramnicu Valcea");
        Console.WriteLine("After removing Ramnicu Valcea:");
        Console.WriteLine(route);

        // Verifică dacă un waypoint există
        Console.WriteLine($"Has Pitesti waypoint: {route.HasWaypoint("Pitesti")}");
        Console.WriteLine($"Has Iasi waypoint: {route.HasWaypoint("Iasi")}");
        
        
        
        
        
        
    }
}