using homework03_AbstractFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Entities.Classes.Apple;

class ApplePhone : ISmartPhone
{
    public string ModelName { get; set; }

    public void ChooseSong(IHeadphone headphone)
    {
        headphone.PlayMusic("\"Never gonna give you up\" by Rick Astley ");
    }

    public void PhoneCall(int number)
    {
        Console.WriteLine($"Calling {number}");
    }
}
