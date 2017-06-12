namespace DesignPatterns.Models.Abstract
{
    class Wolf : Carnivore
    {
        public override string Eat(Herbivore h)
        {
            return GetType().Name + " eats " + h.GetType().Name;
        }
    }
}
