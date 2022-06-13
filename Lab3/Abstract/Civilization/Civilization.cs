using Lab3.Abstract.Finance;
using Lab3.Abstract.Territories;
using Lab3.Abstract.Units;

namespace Lab3.Abstract.Civilization;

public abstract class Civilization
{
    protected readonly ICivilizationInfrastructureFactory _civilizationInfrastructureFactory;

    protected Civilization(ICivilizationInfrastructureFactory civilizationInfrastructureFactory)
    {
        _civilizationInfrastructureFactory = civilizationInfrastructureFactory;
    }

    public ICollection<Unit> Units { get; set; } = new List<Unit>();
    public ICollection<Territory> Territories { get; set; } = new List<Territory>();
    public Finances Finances { get; set; }
    public abstract void InitializeDefaultValues();
}