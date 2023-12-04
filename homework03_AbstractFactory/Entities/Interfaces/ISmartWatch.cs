using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Entities.Interfaces;

interface ISmartWatch
{
    public void ShowTime();
    public void Connect(ISmartPhone phone);
}
