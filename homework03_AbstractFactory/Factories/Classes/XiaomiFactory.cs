using homework03_AbstractFactory.Entities.Classes.Xiaomi;
using homework03_AbstractFactory.Entities.Interfaces;
using homework03_AbstractFactory.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Factories.Classes;

internal class XiaomiFactory : IGadgetFactory
{
    public IHeadphone CreateHeadphone()
    {
        return new XiaomiHeadphones();
    }

    public ISmartPhone CreateSmartPhone(string model)
    {
        return new XiaomiPhone() { ModelName = model};
    }

    public ISmartWatch CreateSmartWatch()
    {
        return new XiaomiWatch();
    }
}
