using Lab3.Abstract.Civilization;

namespace Lab3.Implementation.Civilizations.Spain;

public class SpainCivilizationFactory : CivilizationFactory
{
    private readonly SpainCivilizationInfrastructureFactory _spainCivilizationInfrastructureFactory;

    public SpainCivilizationFactory(SpainCivilizationInfrastructureFactory spainCivilizationInfrastructureFactory)
    {
        _spainCivilizationInfrastructureFactory = spainCivilizationInfrastructureFactory;
    }

    public override Civilization CreateCivilization()
    {
        return new SpainCivilization(_spainCivilizationInfrastructureFactory);
    }
}