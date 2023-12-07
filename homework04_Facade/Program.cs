

using homework04_Facade.Entities;
using homework04_Facade.Services;

var manager = new ManagerService();

manager.MakeOrder(new Item() { Name = "Book", Price = 34 }, 45435435);
var trackCode = manager.ShipmentProcess();
manager.GetOrder();

