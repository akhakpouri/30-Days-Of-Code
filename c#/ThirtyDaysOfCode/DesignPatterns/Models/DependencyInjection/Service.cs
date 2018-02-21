using System;

namespace DesignPatterns.Models.DependencyInjection
{
    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service is Called");
        }
    }
}
