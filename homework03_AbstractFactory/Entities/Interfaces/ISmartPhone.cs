using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Entities.Interfaces;

interface ISmartPhone
{
    public string ModelName { get; set; }     
    public void PhoneCall(int number);

    public void ChooseSong(IHeadphone headphone);

}
