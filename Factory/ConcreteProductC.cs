using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ConcreteProductC : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Your Calzone is being made!");
        }
    }
}
