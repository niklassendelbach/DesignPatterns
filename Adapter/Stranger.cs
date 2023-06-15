using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Stranger
    {
        //klass utifrån
        public void SpecificRequest()
        {
            Console.WriteLine("One pizza for 100SEK");
            Console.WriteLine("****************");
            Console.WriteLine("Choose your Pizza!");
            Console.WriteLine("1. Margerita");
            Console.WriteLine("2. Capricciosa");
            Console.WriteLine("3. Calzone");
        }
    }
}
