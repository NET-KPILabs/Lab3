using Lab3.Abstract.Civilization;
using Lab3.Abstract.Finance;
using Lab3.Abstract.Territories;
using Lab3.Abstract.Units;
using Lab3.Implementation.Finance;
using Lab3.Implementation.Territories.Rome;
using Lab3.Implementation.Units.Rome;

namespace Lab3.Implementation.Civilizations.Rome;

public class RomeCivilizationInfrastructureFactory : ICivilizationInfrastructureFactory
{
    public Aristocrat CreateAristocrat()
    {
        return new RomeAristocrat();
    }

    public Warrior CreateWarrior()
    {
        return new RomeWarrior();
    }

    public Worker CreateWorker()
    {
        return new RomeWorker();
    }

    public Dwelling CreateDwelling()
    {
        return new RomeDwelling();
    }

    public Field CreateField()
    {
        return new RomeField();
    }

    public Factory CreateFactory()
    {
        return new RomeFactory();
    }

    public Wood CreateWood()
    {
        return new RomeWood();
    }

    public Finances CreateFinances()
    {
        return new RomeFinances();
    }
}