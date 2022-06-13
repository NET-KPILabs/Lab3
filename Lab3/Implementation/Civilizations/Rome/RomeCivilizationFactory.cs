using Lab3.Abstract.Civilization;

namespace Lab3.Implementation.Civilizations.Rome;

public class RomeCivilizationFactory : CivilizationFactory
{
    private readonly RomeCivilizationInfrastructureFactory _romeCivilizationInfrastructureFactory;

    public RomeCivilizationFactory(RomeCivilizationInfrastructureFactory romeCivilizationInfrastructureFactory)
    {
        _romeCivilizationInfrastructureFactory = romeCivilizationInfrastructureFactory;
    }

    public override Civilization CreateCivilization()
    {
        return new RomeCivilization(_romeCivilizationInfrastructureFactory);
    }
}