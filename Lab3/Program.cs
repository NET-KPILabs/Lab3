using Lab3.Implementation.Civilizations.Rome;

var romeInfrastructureCivilizationFactory = new RomeCivilizationInfrastructureFactory();
var romeCivilizationFactory = new RomeCivilizationFactory(romeInfrastructureCivilizationFactory);
var civilization = romeCivilizationFactory.CreateCivilization();
civilization.InitializeDefaultValues();

Console.WriteLine("Rome civilization:");
Console.WriteLine("Units:");
foreach (var unit in civilization.Units)
{
    Console.WriteLine(unit);
}

Console.WriteLine("Territories:");
foreach (var territory in civilization.Territories)
{
    Console.WriteLine(territory);
}

Console.WriteLine("Finances:");
Console.WriteLine(civilization.Finances);

Console.WriteLine("Changing unit:");
var uselessUnit = civilization.Units.Last();
civilization.Units.Remove(uselessUnit);
civilization.Units.Add(romeInfrastructureCivilizationFactory.CreateWorker());
foreach (var unit in civilization.Units)
{
    Console.WriteLine(unit);
}


