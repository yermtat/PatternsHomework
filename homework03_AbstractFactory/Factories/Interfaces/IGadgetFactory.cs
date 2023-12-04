using homework03_AbstractFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Factories.Interfaces;

interface IGadgetFactory
{
    public IHeadphone CreateHeadphone();
    public ISmartPhone CreateSmartPhone(string model);
    public ISmartWatch CreateSmartWatch();
}
