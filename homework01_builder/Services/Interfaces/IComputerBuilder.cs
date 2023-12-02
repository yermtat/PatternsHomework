using homework01_builder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework01_builder.Services.Interfaces;

interface IComputerBuilder
{
    public Computer ComputerToBuild { get; set; }
    public void SetProcessor();
    public void SetMotherBoard();
    public void SetRam();
    public void SetStorage();
    public void SetVideocard();
    public void SetSoundcard();
    public void SetMonitor();

}
