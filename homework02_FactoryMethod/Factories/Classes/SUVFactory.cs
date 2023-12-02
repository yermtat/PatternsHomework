using homework02_FactoryMethod.Entities.Classes;
using homework02_FactoryMethod.Entities.Interfaces;
using homework02_FactoryMethod.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_FactoryMethod.Factories.Classes;

class SUVFactory : IAutomobileFactory
{
    public IAutomobile CreateAutomobile()
    {
        return new SUV() { Name = "Hyundai Venue", Seats = 5, SuvType = "А-SUV" };
    }
}
