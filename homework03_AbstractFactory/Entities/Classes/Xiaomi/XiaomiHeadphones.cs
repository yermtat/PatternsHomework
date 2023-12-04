using homework03_AbstractFactory.Entities.Classes.Apple;
using homework03_AbstractFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Entities.Classes.Xiaomi;

class XiaomiHeadphones : IHeadphone
{
    public void BluetoothConnect(ISmartPhone phone)
    {
        if (phone.GetType() == typeof(XiaomiPhone))
        {
            Console.WriteLine("Connected and synchronized");
        }
        else Console.WriteLine("Connected");
    }

    public void PlayMusic(string song)
    {
        Console.WriteLine(song + "is playing");
    }
}
