namespace Sistem_de_Management_al_Transporturilor_Globale;

public class Route
{
    public string Origin{get;set;}
    public string Destination{get;set;}
    public double Distance{get;set;}
    public List<string> Waypoints{get;set;}

    public Route(string origin, string destination, int distance, List<string> waypoints)
    {
        Origin = origin;
        Destination = destination;
        Distance = distance;
        Waypoints = waypoints ?? new List<string>(); //verifică dacă valoarea din stânga sa (waypoints) este null.
                                                     //Dacă este null, returnează valoarea din dreapta (new List<string>()).

                                                     //new List<string>()
                                                     //Dacă waypoints este null, se creează o listă goală de tip string.
    }
    
    
    // Adaugă un waypoint (punct intermediar) în lista de waypoints
    public void AddWaypoint(string waypoint)
    {
        if (!string.IsNullOrEmpty(waypoint) && !Waypoints.Contains(waypoint))
        {
            Waypoints.Add(waypoint);
        }
        else
        {
            Console.WriteLine("Invalid or duplicate waypoint.");
        }
    }

    
    // Elimină un waypoint (punct intermediar) din lista de waypoints
    public void RemoveWaypoint(string waypoint)
    {
        if (Waypoints.Contains(waypoint))
        {
            Waypoints.Remove(waypoint);
        }
        else
        {
            Console.WriteLine("Waypoint not found.");
        }
    }

    // Verifică dacă un waypoint există în listă
    public bool HasWaypoint(string waypoint)
    {
        return Waypoints.Contains(waypoint);
    }

    // Afișează toate waypoints
    public void DisplayWaypoints()
    {
        if (Waypoints.Count > 0)
        {
            Console.WriteLine("Waypoints:");
            foreach (var waypoint in Waypoints)
            {
                Console.WriteLine($"- {waypoint}");
            }
        }
        else
        {
            Console.WriteLine("No waypoints available.");
        }
    }
    
    
    
    
    
    

    public override string ToString()
    {
        string waypoints = Waypoints.Count > 0 ? $"({string.Join(", ", Waypoints)})" : "";
        return $"{Origin} -> {Destination} ({Distance} km){waypoints}";
    }
}