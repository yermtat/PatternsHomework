using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework06_Flyweight.Flyweight.Interfaces;

interface IFlyweight
{
    public bool IsEnemy { get; set; }
    public string ClassType { get; set; }
    public string Weapon { get; set; }
}
