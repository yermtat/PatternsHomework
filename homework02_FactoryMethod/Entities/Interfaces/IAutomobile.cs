using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace homework02_FactoryMethod.Entities.Interfaces;

interface IAutomobile
{
    public string Name { get; set; }
    public int Seats { get; set; }
    public string GetInfo();
}
