using homework02_FactoryMethod.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_FactoryMethod.Entities.Classes;

class Truck : IAutomobile
{
    public string Name { get; set; }
    public int Seats { get; set; }
    public string SizeType { get; set; }

    public string GetInfo()
    {
        return $"Car type: truck\nModel: {Name}\nSeats qt.: {Seats}\n" +
            $"Size type: {SizeType}";
    }
}
