using Lab3.Abstract.Finance;
using Lab3.Abstract.Territories;
using Lab3.Abstract.Units;

namespace Lab3.Abstract.Civilization;

public interface ICivilizationInfrastructureFactory
{
    public Aristocrat CreateAristocrat();
    public Warrior CreateWarrior();
    public Worker CreateWorker();
    public Dwelling CreateDwelling();
    public Field CreateField();
    public Factory CreateFactory();
    public Wood CreateWood();
    public Finances CreateFinances();
}