namespace Sistem_de_gestionare_a_Bancilor;

public class Client
{
    public string Name { get; set; }
    public List<Cont> Conturi { get; private set; }

    public Client(string name)
    {
        Name = name;
        Conturi = new List<Cont>();
    }

    public void AdaugaCont(Cont cont)
    {
        Conturi.Add(cont);
    }

    public void AfiseazaCont()
    {
        Console.WriteLine($"Client: {Name}");
        foreach (var cont in Conturi)
        {
            Console.WriteLine($"Cont #{cont.NumarCont} - Sold {cont.Sold} lei");
        }
    }
    
    
    
    
    
    
}
