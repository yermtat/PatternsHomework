using homework01_builder.Entities;
using homework01_builder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework01_builder.Services.Classes;

class OfficeComputerBuilder : IComputerBuilder
{
    public Computer ComputerToBuild { get; set; }

    public OfficeComputerBuilder()
    {
        ComputerToBuild = new();
    }

    public void SetMotherBoard()
    {
        ComputerToBuild.MotherBoard = "Asrock B450M/AC AM4 B450";
    }

    public void SetProcessor()
    {
        ComputerToBuild.Processor = "MD Ryzen 3 2200G";
    }

    public void SetRam()
    {
        ComputerToBuild.Ram = "2x4GB";
    }

    public void SetSoundcard()
    {

        ComputerToBuild.Soundcard = "None";
    }

    public void SetStorage()
    {
        ComputerToBuild.Storage = "480GB";
    }

    public void SetVideocard()
    {
        ComputerToBuild.Videocard = "None";
    }

    public void SetMonitor()
    {
        ComputerToBuild.Monitor = "Dell U2723QE 3";
    }
}
