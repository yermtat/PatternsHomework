using homework03_AbstractFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Entities.Classes.Apple;

internal class AirPods : IHeadphone
{
    public void BluetoothConnect(ISmartPhone phone)
    {
        if (phone.GetType() == typeof(ApplePhone))
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
