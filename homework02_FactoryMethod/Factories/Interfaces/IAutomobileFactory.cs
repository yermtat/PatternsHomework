using homework02_FactoryMethod.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_FactoryMethod.Factories.Interfaces;

interface IAutomobileFactory
{
    public IAutomobile CreateAutomobile();
}
