
namespace DesignPatterns.Models.Abstract
{
    class Lion : Carnivore
    {
        public override string Eat(Herbivore h)
        {
            return GetType().Name + " eats " + h.GetType().Name;
        }
    }
}
