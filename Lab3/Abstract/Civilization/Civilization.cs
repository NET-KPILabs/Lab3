using Lab3.Abstract.Finance;
using Lab3.Abstract.Territories;
using Lab3.Abstract.Units;

namespace Lab3.Abstract.Civilization;

public class Civilization
{
    private readonly ICivilizationInfrastructureFactory _civilizationInfrastructureFactory;
    private List<Unit> _units = new List<Unit>();
    private List<Territory> _territories = new List<Territory>();

    public Civilization(ICivilizationInfrastructureFactory civilizationInfrastructureFactory)
    {
        _civilizationInfrastructureFactory = civilizationInfrastructureFactory;
    }

    public IReadOnlyCollection<Unit> Units => _units;
    public IReadOnlyCollection<Territory> Territories => _territories;
    public Finances Finances { get; private set; }

    public void CreateCitizens()
    {
        _units.Add(_civilizationInfrastructureFactory.CreateAristocrat());
        _units.Add(_civilizationInfrastructureFactory.CreateWorker());
        _units.Add(_civilizationInfrastructureFactory.CreateWarrior());
    }

    public void CreateTerritories()
    {
        _territories.Add(_civilizationInfrastructureFactory.CreateDwelling());
        _territories.Add(_civilizationInfrastructureFactory.CreateFactory());
        _territories.Add(_civilizationInfrastructureFactory.CreateField());
        _territories.Add(_civilizationInfrastructureFactory.CreateWood());
    }

    public void CreateFinances()
    {
        Finances = _civilizationInfrastructureFactory.CreateFinances();
    }
}