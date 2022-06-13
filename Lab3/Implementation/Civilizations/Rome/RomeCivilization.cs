using Lab3.Abstract.Civilization;

namespace Lab3.Implementation.Civilizations.Rome;

public class RomeCivilization : Civilization
{
    public RomeCivilization(ICivilizationInfrastructureFactory civilizationInfrastructureFactory) 
        : base(civilizationInfrastructureFactory)
    {
    }

    public override void InitializeDefaultValues()
    {
        Units.Add(_civilizationInfrastructureFactory.CreateWarrior());
        Units.Add(_civilizationInfrastructureFactory.CreateWorker());
        Units.Add(_civilizationInfrastructureFactory.CreateAristocrat());
        Territories.Add(_civilizationInfrastructureFactory.CreateFactory());
        Territories.Add(_civilizationInfrastructureFactory.CreateField());
        Finances = _civilizationInfrastructureFactory.CreateFinances();
    }
}