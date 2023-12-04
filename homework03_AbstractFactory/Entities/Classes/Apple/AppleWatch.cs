using homework03_AbstractFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Entities.Classes.Apple;

internal class AppleWatch : ISmartWatch
{
    public void Connect(ISmartPhone phone)
    {
        if (phone.GetType() == typeof(ApplePhone))
        {
            Console.WriteLine("Connected and synchronized with Iphone");
        }
        else Console.WriteLine("Connected");
    }

    public void ShowTime()
    {
        Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
}
