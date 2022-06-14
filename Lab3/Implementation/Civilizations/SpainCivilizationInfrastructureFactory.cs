using Lab3.Abstract.Civilization;
using Lab3.Abstract.Finance;
using Lab3.Abstract.Territories;
using Lab3.Abstract.Units;
using Lab3.Implementation.Finance;
using Lab3.Implementation.Territories.Spain;
using Lab3.Implementation.Units.Spain;

namespace Lab3.Implementation.Civilizations.Spain;

public class SpainCivilizationInfrastructureFactory : ICivilizationInfrastructureFactory
{
    public Aristocrat CreateAristocrat()
    {
        return new SpainAristocrat();
    }

    public Warrior CreateWarrior()
    {
        return new SpainWarrior();
    }

    public Worker CreateWorker()
    {
        return new SpainWorker();
    }

    public Dwelling CreateDwelling()
    {
        return new SpainDwelling();
    }

    public Field CreateField()
    {
        return new SpainField();
    }

    public Factory CreateFactory()
    {
        return new SpainFactory();
    }

    public Wood CreateWood()
    {
        return new SpainWood();
    }

    public Finances CreateFinances()
    {
        return new SpainFinances();
    }
}