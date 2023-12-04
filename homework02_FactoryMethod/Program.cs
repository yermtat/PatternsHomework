
using homework02_FactoryMethod.Entities.Classes;
using homework02_FactoryMethod.Factories.Classes;
using homework02_FactoryMethod.Factories.Interfaces;

IAutomobileFactory sedanFactory = new SedanFactory();
IAutomobileFactory suvFactory = new SUVFactory();
IAutomobileFactory truckFactory = new TruckFactory();

Sedan sedan = sedanFactory.CreateAutomobile() as Sedan;
Console.WriteLine(sedan.GetInfo() + "\n");

SUV suv = suvFactory.CreateAutomobile() as SUV;
Console.WriteLine(suv.GetInfo() + "\n");

Truck truck = truckFactory.CreateAutomobile() as Truck;
Console.WriteLine(truck.GetInfo());

