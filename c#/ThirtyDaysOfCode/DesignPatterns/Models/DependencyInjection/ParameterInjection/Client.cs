using System;

namespace DesignPatterns.Models.DependencyInjection.ParameterInjection
{
    public class Client
    {
        private IService _service;

        public IService Service
        {
            set => _service = value;
        }

        public void Start()
        {
            Console.WriteLine("Service Started");
            _service.Serve();
        }
    }
}
