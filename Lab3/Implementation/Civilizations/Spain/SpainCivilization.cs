using Lab3.Abstract.Civilization;

namespace Lab3.Implementation.Civilizations.Spain;

public class SpainCivilization : Civilization
{
    public SpainCivilization(ICivilizationInfrastructureFactory civilizationInfrastructureFactory) 
        : base(civilizationInfrastructureFactory)
    {
    }

    public override void InitializeDefaultValues()
    {
        Units.Add(_civilizationInfrastructureFactory.CreateAristocrat());
        Units.Add(_civilizationInfrastructureFactory.CreateWorker());
        Territories.Add(_civilizationInfrastructureFactory.CreateFactory());
        Territories.Add(_civilizationInfrastructureFactory.CreateDwelling());
        Finances = _civilizationInfrastructureFactory.CreateFinances();
    }
}