namespace Sistem_de_gestionare_a_Bancilor;

public class Banca
{
    public string Nume { get; set; }
    private List<Client> clienti;

    public Banca(string nume)
    {
        Nume = nume;
        clienti = new List<Client>();
        
    }

    public void AdaugaClient(Client client)
    {
        clienti.Add(client);
    }
    
    public void AfiseazaClienti()
    {
        Console.WriteLine($"Banca {Nume} - Lista de clienti:");
        foreach (var client in clienti)
        {
            client.AfiseazaCont();
        }
    }
    
    
    
    
    
    
    
}