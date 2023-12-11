using homework06_Flyweight.Flyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework06_Flyweight.Flyweight.Clsses;

class NpcFactory : IFlyWeightFactory
{
    public List<IFlyweight> UnitTypes { get; set; }
    public NpcFactory()
    {
        UnitTypes = new List<IFlyweight>();
    }

    public IFlyweight GetUnitType(bool isEnemy, string classType, string weapon)
    {
        var type = UnitTypes.Find(t => t.IsEnemy == isEnemy && t.ClassType == classType && t.Weapon == weapon);
        
        if (type != null) return type;
        else
        {
            UnitTypes.Add(new NpcType() {IsEnemy = isEnemy, ClassType = classType, Weapon = weapon});
            return UnitTypes.Last();
        }
    }
}
