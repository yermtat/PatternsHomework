using homework02_FactoryMethod.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_FactoryMethod.Entities.Classes;

class SUV : IAutomobile
{
    public string Name { get; set; }
    public int Seats { get; set; }
    public string SuvType { get; set; }

    public string GetInfo()
    {
        return $"Car type: SUV\nModel: {Name}\nSeats qt.: {Seats}\n" +
            $"SUV type: {SuvType}";
    }
}
