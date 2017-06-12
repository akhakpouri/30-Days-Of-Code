using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Factories.Abstract;
using DesignPatterns.Models.Abstract;

namespace DesignPatternsTest
{
    [TestClass]
    public class AbstractTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                var africa = new AfricaFactory();
                var world = new AnimalWorld(africa);                
                Console.WriteLine(world.RunFoodChain());

                var america = new AmericaFactory();
                world = new AnimalWorld(america);
                Console.WriteLine(world.RunFoodChain());
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }


    }
}
