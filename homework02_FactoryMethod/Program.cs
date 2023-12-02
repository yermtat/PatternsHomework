
using homework02_FactoryMethod.Entities.Classes;
using homework02_FactoryMethod.Factories.Classes;

var sedanFactory = new SedanFactory();
var suvFactory = new SUVFactory();
var truckFactory = new TruckFactory();

Sedan sedan = sedanFactory.CreateAutomobile() as Sedan;
Console.WriteLine(sedan.GetInfo() + "\n");

SUV suv = suvFactory.CreateAutomobile() as SUV;
Console.WriteLine(suv.GetInfo() + "\n");

Truck truck = truckFactory.CreateAutomobile() as Truck;
Console.WriteLine(truck.GetInfo());

