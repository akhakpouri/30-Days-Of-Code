using System;

namespace DesignPatterns.Models.DependencyInjection.ConstructorInjection
{
    /// <summary>
    /// This is an example of a constructor injection
    /// </summary>
    public class Client
    {
        private readonly IService _service;

        public Client(IService service)
        {
            this._service = service;
        }

        public void Start()
        {
            Console.WriteLine("Service Started.");
            this._service.Serve();
        }
    }
}
