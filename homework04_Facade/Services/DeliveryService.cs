using homework04_Facade.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework04_Facade.Services;

internal class DeliveryService
{
    public void PrepareForDelivery(string item)
    {
        Console.WriteLine($"Item \"{item} prepared for delivery");
    }
    
    public string Shipment()
    {
        string trackCode = "AAAAAAAAAAAAA";
        Console.WriteLine($"track code: {trackCode}");
        return trackCode;

    }

    public void UpdateStatus()
    {
        Console.WriteLine("Delivery status updated");
    }

    public void DeliveryFinish()
    {
        Console.WriteLine("Delivered");
    }
}
