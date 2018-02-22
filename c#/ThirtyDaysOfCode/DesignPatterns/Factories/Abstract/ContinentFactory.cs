using DesignPatterns.Models.Abstract;

namespace DesignPatterns.Factories.Abstract
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();

        public string Test { get; set; }

        protected virtual void Hello()
        {
            
        }
    }
}
