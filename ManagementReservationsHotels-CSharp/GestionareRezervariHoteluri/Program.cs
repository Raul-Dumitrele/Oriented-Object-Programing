using System;
using GestionareRezervariHoteluri;


class Program
{
    static void Main()
    {
        var hotel = new Hotel("Hotel de lux", "Timisoara");
        var cameraStandard = new CameraStandard("Camera Standard",10);
        var cameraDeluxe = new CameraDeluxe("Camera deluxe",5);
        
        hotel.AdaugaCamera(cameraStandard);
        hotel.AdaugaCamera(cameraDeluxe);
        
        hotel.AdaugaRezervare(new Rezervare("Ion Popescu","071233123","Camera Standard",1,10));
        hotel.AdaugaRezervare(new Rezervare("Ion Popescu","071223123","Camera Deluxe",1,10));
     
        hotel.AfiseazaRezervariCamere();
        hotel.AfiseazaNumarTotalPersoane();
    }
    
}