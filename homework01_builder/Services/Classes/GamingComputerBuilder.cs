using homework01_builder.Entities;
using homework01_builder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework01_builder.Services.Classes;

class GamingComputerBuilder : IComputerBuilder
{
    public Computer ComputerToBuild { get; set; }

    public GamingComputerBuilder()
    {
        ComputerToBuild = new Computer();
    }

    public void SetMotherBoard()
    {
        ComputerToBuild.MotherBoard = "Asus ROG Strix X670E-E";
    }

    public void SetProcessor()
    {
        ComputerToBuild.Processor = "AMD Ryzen 9 7900X3D";
    }

    public void SetRam()
    {
        ComputerToBuild.Ram = "G.Skill Trident Z5 RGB DDR5 (2 x 16GB) DDR5 6400";
    }

    public void SetSoundcard()
    {

        ComputerToBuild.Soundcard = "None";
    }

    public void SetStorage()
    {
        ComputerToBuild.Storage = "Samsung 990 Pro (4TB)";
    }

    public void SetVideocard()
    {
        ComputerToBuild.Videocard = "Nvidia RTX 4090";
    }

    public void SetMonitor()
    {
        ComputerToBuild.Monitor = "Dell Alienware AW2524H 36";
    }
}
