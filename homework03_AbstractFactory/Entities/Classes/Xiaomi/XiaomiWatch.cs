using homework03_AbstractFactory.Entities.Classes.Apple;
using homework03_AbstractFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Entities.Classes.Xiaomi;

internal class XiaomiWatch : ISmartWatch
{
    public void Connect(ISmartPhone phone)
    {
        if (phone.GetType() == typeof(XiaomiPhone))
        {
            Console.WriteLine("Connected and synchronized with Xiaomi");
        }
        else Console.WriteLine("Connected");
    }

    public void ShowTime()
    {
        Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
}
