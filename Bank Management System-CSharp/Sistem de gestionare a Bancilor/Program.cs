using Sistem_de_gestionare_a_Bancilor;

public class Program
{
    public static void Main()
    {
        Banca banca = new Banca("Transilvania");

        Client client1 = new Client("Preda Ionut");
        
        //AICI FOLOSESC MAI MULT CLASA COPIL DIRECT
        ContCurent contCurent = new ContCurent(1001, 5000);
        ContEconomii contEconomii = new ContEconomii(1002, 2000, 0.03);

        client1.AdaugaCont(contCurent);
        client1.AdaugaCont(contEconomii);
        
        banca.AdaugaClient(client1);
        
        client1.AfiseazaCont();
        
        //((ContEconomii)contEconomii).AdaugaDobanda();
        contEconomii.AdaugaDobanda();
        
        banca.AfiseazaClienti();



    }
}