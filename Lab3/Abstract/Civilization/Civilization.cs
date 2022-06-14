using Lab3.Abstract.Finance;
using Lab3.Abstract.Territories;
using Lab3.Abstract.Units;

namespace Lab3.Abstract.Civilization;

public class Civilization
{
    private readonly ICivilizationInfrastructureFactory _civilizationInfrastructureFactory;

    public Civilization(ICivilizationInfrastructureFactory civilizationInfrastructureFactory)
    {
        _civilizationInfrastructureFactory = civilizationInfrastructureFactory;
    }

    public ICollection<Unit> Units { get; } = new List<Unit>();
    public ICollection<Territory> Territories { get; } = new List<Territory>();
    public Finances Finances { get; set; }

    public void InitializeDefaultValues()
    {
        Units.Add(_civilizationInfrastructureFactory.CreateAristocrat());
        Units.Add(_civilizationInfrastructureFactory.CreateWorker());
        Units.Add(_civilizationInfrastructureFactory.CreateWarrior());
        Territories.Add(_civilizationInfrastructureFactory.CreateDwelling());
        Territories.Add(_civilizationInfrastructureFactory.CreateWood());
        Finances = _civilizationInfrastructureFactory.CreateFinances();
    }
}