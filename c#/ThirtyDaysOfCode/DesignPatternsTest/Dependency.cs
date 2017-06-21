using System;
using DesignPatterns.Models.DI;
using DesignPatterns.Models.DI.CI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest
{
    [TestClass]
    public class Dependency
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var client = new Client(new Service());
            client.Start();
        }

        [TestMethod]
        public void PropertyTest()
        {
            var client = new DesignPatterns.Models.DI.PI.Client()
            {
                Service = new Service()
            };
            client.Start();
        }
    }
}
