using homework03_AbstractFactory.Entities.Classes.Apple;
using homework03_AbstractFactory.Entities.Interfaces;
using homework03_AbstractFactory.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Factories.Classes;

class AppleFactory : IGadgetFactory
{
    public IHeadphone CreateHeadphone()
    {
        return new AirPods();
    }

    public ISmartPhone CreateSmartPhone(string model)
    {
        return new ApplePhone() { ModelName = model };
    }

    public ISmartWatch CreateSmartWatch()
    {
        return new AppleWatch();
    }
}
