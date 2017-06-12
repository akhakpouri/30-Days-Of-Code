using System;
using DesignPatterns.Models.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (var document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "---");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            Assert.IsTrue(true);
        }
    }
}
