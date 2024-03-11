using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Computers
{
   
    public class Computer
    {
        public void Start()
        {
            Console.WriteLine($"{GetType().Name} is starting");

        }  
        public void Shutdown()
        {
            Console.WriteLine($"{GetType().Name} is shutting down");
        }
    }
}
