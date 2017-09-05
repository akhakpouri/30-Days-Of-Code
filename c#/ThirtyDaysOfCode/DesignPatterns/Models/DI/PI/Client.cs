using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.DI.PI
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
