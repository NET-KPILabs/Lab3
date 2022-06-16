using Lab3.Abstract.Civilization;
using Lab3.Implementation.Civilizations.Rome;

var romeInfrastructureCivilizationFactory = new RomeCivilizationInfrastructureFactory();
var romeCivilization = new Civilization(romeInfrastructureCivilizationFactory);

romeCivilization.CreateCitizens();

Console.WriteLine("Rome civilization:");
Console.WriteLine("Units:");
foreach (var unit in romeCivilization.Units)
{
    Console.WriteLine(unit);
}

Console.WriteLine("Adding territories and finances:");
romeCivilization.CreateTerritories();
romeCivilization.CreateFinances();
Console.WriteLine("Territories:");
foreach (var territory in romeCivilization.Territories)
{
    Console.WriteLine(territory);
}

Console.WriteLine("Finances:");
Console.WriteLine(romeCivilization.Finances);




