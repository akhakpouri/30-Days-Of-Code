using DesignPatterns.Factories.Abstract;

namespace DesignPatterns.Models.Abstract
{
    public class AnimalWorld
    {
        public readonly Herbivore _herbivore;
        public readonly Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public string RunFoodChain()
        {
            return _carnivore.Eat(_herbivore);
        }
    }
}