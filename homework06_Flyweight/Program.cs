
using homework06_Flyweight.Entities;
using homework06_Flyweight.Flyweight.Clsses;
using homework06_Flyweight.Flyweight.Interfaces;

IFlyWeightFactory factory = new NpcFactory();

Npc npc1 = new Npc() { Name = "Lucien Lachance", Level = 34, Role = "Speaker of the dark brotherhood",
Type = factory.GetUnitType(false, "Assassin", "dagger")};

Npc npc2 = new Npc() { Name = "Vicente Valtieri", Level = 30, Role = "Vampire, member of the dark brotherhood",
Type = factory.GetUnitType(false, "Assassin", "dagger")};

Npc npc3 = new Npc() { Name = "Sheogorath", Level = 42, Role = "Daedric Prince of Madness",
Type = factory.GetUnitType(false, "Daedra", "Staff")};

Console.WriteLine(npc1);
Console.WriteLine(npc2);
Console.WriteLine(npc3);

