namespace Sistem_de_Management_al_Transporturilor_Globale;

public class Order
{
    public string OrderId { get; set; }
    public string ClientName { get; set; }
    public double Weight { get; set; }
    public string Destination { get; set; }
    public string Status { get; set; }

    public Order(string orderId, string clientName, double weight, string destination)
    {
        OrderId = orderId;
        ClientName = clientName;
        Weight = weight;
        Destination = destination;
        Status = "Pending";
    }

    public override string ToString()
    {
        return $"Order [ID: {OrderId}, Client: {ClientName}, Weight: {Weight} tons, Destination: {Destination}, Status: {Status}]";
    }
    
    
}