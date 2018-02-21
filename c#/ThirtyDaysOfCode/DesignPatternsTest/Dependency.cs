using DesignPatterns.Models.DependencyInjection;
using DesignPatterns.Models.DependencyInjection.ConstructorInjection;
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
            var client = new DesignPatterns.Models.DependencyInjection.ParameterInjection.Client()
            {
                Service = new Service()
            };
            client.Start();
        }
    }
}
