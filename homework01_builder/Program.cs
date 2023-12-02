
using homework01_builder.Services.Classes;
using homework01_builder.Services.Interfaces;

IComputerBuilder officeBuilder = new OfficeComputerBuilder();
IComputerBuilder gamingBuilder = new GamingComputerBuilder();
IComputerBuilder designBuilder = new DesignerComputerBuilder();

ComputerDirector officeDirector = new ComputerDirector(officeBuilder);
ComputerDirector gamingDirector = new ComputerDirector(gamingBuilder);
ComputerDirector designDirector = new ComputerDirector(designBuilder);

var officePC = officeDirector.ConstructComputer();
var gamingPC = gamingDirector.ConstructComputer();
var designPC = designDirector.ConstructComputer();

Console.WriteLine(officePC);
Console.WriteLine();
Console.WriteLine(gamingPC);
Console.WriteLine();
Console.WriteLine(designPC);
