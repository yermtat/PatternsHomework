using homework01_builder.Entities;
using homework01_builder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework01_builder.Services.Classes;

class DesignerComputerBuilder : IComputerBuilder
{
    public Computer ComputerToBuild { get; set; }

    public DesignerComputerBuilder()
    {
        ComputerToBuild = new();
    }

    public void SetMotherBoard()
    {
        ComputerToBuild.MotherBoard = "MSI Pro X670-P";
    }

    public void SetProcessor()
    {
        ComputerToBuild.Processor = "AMD R9 7950X";
    }

    public void SetRam()
    {
        ComputerToBuild.Ram = "64GB (2 X 32GB) DDR5-6000";
    }

    public void SetSoundcard()
    {

        ComputerToBuild.Soundcard = "None";
    }

    public void SetStorage()
    {
        ComputerToBuild.Storage = "2TB Crucial SATA SSD";
    }

    public void SetVideocard()
    {
        ComputerToBuild.Videocard = "RTX 3060 Ti";
    }

    public void SetMonitor()
    {
        ComputerToBuild.Monitor = "Asus ProArt 32 inch";
    }
}
