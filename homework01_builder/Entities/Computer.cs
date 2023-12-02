using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework01_builder.Entities;

class Computer
{
    public string Processor { get; set; }
    public string MotherBoard { get; set; }
    public string Ram { get; set; }
    public string Storage { get; set; }
    public string Videocard { get; set; }
    public string Soundcard { get; set; }
    public string Monitor { get; set; }

    public override string ToString()
    {
        return $"CPU: {Processor}\nMotherboard: {MotherBoard}\nRAM: {Ram}\nStorage: {Storage}\n" +
            $"GPU: {Videocard}\nAudiocard: {Soundcard}\nMonitor: {Monitor}";
    }
}
