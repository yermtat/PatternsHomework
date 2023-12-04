using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_AbstractFactory.Entities.Interfaces;

interface IHeadphone
{
    public void PlayMusic(string song);

    public void BluetoothConnect(ISmartPhone phone);
}
