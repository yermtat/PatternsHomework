using homework06_Flyweight.Flyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework06_Flyweight.Entities;

class Npc : IUnit
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Level { get; set; }
    public IFlyweight Type { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}\nRole: {Role}\nLevel: {Level}\n{Type}";
    }
}
