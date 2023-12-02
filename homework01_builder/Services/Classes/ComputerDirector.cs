using homework01_builder.Entities;
using homework01_builder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework01_builder.Services.Classes;

class ComputerDirector
{
    private readonly IComputerBuilder _builder;

    public ComputerDirector(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public Computer ConstructComputer()
    {
        _builder.SetMotherBoard();
        _builder.SetProcessor();
        _builder.SetVideocard();
        _builder.SetStorage();
        _builder.SetRam();
        _builder.SetSoundcard();
        _builder.SetMonitor();

        return _builder.ComputerToBuild;
    }
}
