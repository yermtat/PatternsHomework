using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework06_Flyweight.Flyweight.Interfaces;

interface IFlyWeightFactory
{
    public List<IFlyweight> UnitTypes { get; set; }
    public IFlyweight GetUnitType(bool isEnemy, string classType, string weapon);
}
