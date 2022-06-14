using Lab3.Abstract.Civilization;
using Lab3.Implementation.Civilizations.Rome;

var romeInfrastructureCivilizationFactory = new RomeCivilizationInfrastructureFactory();
var romeCivilization = new Civilization(romeInfrastructureCivilizationFactory);

romeCivilization.InitializeDefaultValues();

Console.WriteLine("Rome civilization:");
Console.WriteLine("Units:");
foreach (var unit in romeCivilization.Units)
{
    Console.WriteLine(unit);
}

Console.WriteLine("Territories:");
foreach (var territory in romeCivilization.Territories)
{
    Console.WriteLine(territory);
}

Console.WriteLine("Finances:");
Console.WriteLine(romeCivilization.Finances);

Console.WriteLine("Changing unit:");
var uselessUnit = romeCivilization.Units.Last();
romeCivilization.Units.Remove(uselessUnit);
romeCivilization.Units.Add(romeInfrastructureCivilizationFactory.CreateWorker());
foreach (var unit in romeCivilization.Units)
{
    Console.WriteLine(unit);
}


