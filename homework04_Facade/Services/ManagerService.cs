using homework04_Facade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework04_Facade.Services;

class ManagerService
{
    private readonly DeliveryService _deliveryService;
    private readonly PaymentService _paymentService;

    public ManagerService()
    {
        _deliveryService = new DeliveryService();
        _paymentService = new PaymentService();
    }

    public void MakeOrder(Item item, int cardNumber)
    {
        _paymentService.Payment(cardNumber, item.Price);
        _deliveryService.PrepareForDelivery(item.Name);
    }

    public string ShipmentProcess()
    {
        _deliveryService.UpdateStatus();
        return _deliveryService.Shipment();
    }
    public void GetOrder()
    {
        _deliveryService.UpdateStatus();
        _deliveryService.DeliveryFinish();    
    }
}
