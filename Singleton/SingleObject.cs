using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    //singleton
    internal class SingleObject
    {
        private static int CountInstance = 0;
        private static SingleObject instance = null;
        private SingleObject()
        {
            CountInstance++;
            Console.WriteLine("******************");
            Console.WriteLine("Log");
            Console.WriteLine("Session: " + CountInstance.ToString());
        }
        public static SingleObject GetInstance()
        {
                if (instance == null)
                {
                    instance = new SingleObject();         
                }
                return instance;
        }
        public void GetDetails(string details)
        {
            Console.WriteLine(details);
        }
    }
}
