
using System.Collections.Generic;

namespace DesignPatterns.Models.Abstract
{
    public abstract class Carnivore
    {
        public abstract string Eat(Herbivore h);

        public abstract string EatsAll(IEnumerable<Herbivore> h);
    }
}
