using homework06_Flyweight.Flyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework06_Flyweight.Entities;

interface IUnit
{
    public IFlyweight Type { get; set; }
}
