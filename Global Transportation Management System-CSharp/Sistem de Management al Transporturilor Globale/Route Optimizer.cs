namespace Sistem_de_Management_al_Transporturilor_Globale;

public class Route_Optimizer
{
    public Route FindShortestRoute(List<Route> routes, string origin, string destination)
    {
        return routes
            .Where(r => r.Origin == origin && r.Destination == destination)
            .OrderBy(r => r.Distance) // Aici trebuie să folosești 'r' pentru fiecare obiect Route
            .FirstOrDefault(); // Returnează prima rută cu distanța minimă, sau null dacă nu există
    }

    // Aceasta functie imi gaseste cea mai rapida ruta care pleaca din Origine si ajunge la Destinatia dorita si distanta
    
    
    
    /*SE MAI POATE FACE SI ASA MAI PE PASI ,MAI SIMPLU 
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Globalization;

        namespace Sistem_de_Management_al_Transporturilor_Globale
        {
            public class Route_Optimizer
            {
                // Funcție pentru a normaliza șirurile, adică pentru a îndepărta diacriticele și a face comparația case-insensitive
                public static string NormalizeString(string input)
                {
                    string normalized = input.Normalize(NormalizationForm.FormD);
                    var chars = normalized.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
                    return new string(chars).ToLower(); // Conversia în litere mici
                }

                public Route FindShortestRoute(List<Route> routes, string origin, string destination)
                {
                    // Normalizează și convertește în litere mici
                    origin = NormalizeString(origin);
                    destination = NormalizeString(destination);

                    // Filtrarea rutelor care corespund originului și destinației
                    var filteredRoutes = routes.Where(r => 
                        NormalizeString(r.Origin) == origin && NormalizeString(r.Destination) == destination
                    ).ToList();

                    // Debugging
                    Console.WriteLine($"Filtered Routes ({origin} -> {destination}):");
                    foreach (var route in filteredRoutes)
                    {
                        Console.WriteLine(route);
                    }

                    // Dacă nu există rute valide, returnăm null
                    if (!filteredRoutes.Any()) 
                    {
                        Console.WriteLine("No routes found for the given origin and destination.");
                        return null;
                    }

                    // Returnează prima rută cu distanța minimă
                    return filteredRoutes.OrderBy(r => r.Distance).FirstOrDefault();
                }
            }
        }
     */
    
}