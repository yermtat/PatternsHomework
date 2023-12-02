using homework02_FactoryMethod.Entities.Classes;
using homework02_FactoryMethod.Entities.Interfaces;
using homework02_FactoryMethod.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_FactoryMethod.Factories.Classes;

class SedanFactory : IAutomobileFactory
{
    public IAutomobile CreateAutomobile()
    {
        return new Sedan() { Name = "Volkswagen Käfer", Doors = 2, Seats = 4, Windows = 4 };
    }

}
