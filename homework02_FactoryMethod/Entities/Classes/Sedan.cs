using homework02_FactoryMethod.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_FactoryMethod.Entities.Classes;

class Sedan : IAutomobile
{
    public string Name { get; set; }
    public int Seats { get; set; }
    public int Doors { get; set; }
    public int Windows { get; set; }

    public string GetInfo()
    {
        return $"Car type: sedan\nModel: {Name}\nSeats qt.: {Seats}\n" +
            $"Doors qt.: {Doors}\nWindows qt.: {Windows}";
    }
}
