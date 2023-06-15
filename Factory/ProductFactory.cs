using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ProductFactory
    {
        public IProduct CreateProduct(string productName)
        {
            switch (productName) 
            {
                case "ProductOne":
                    return new ConcreteProductA();
            
                case "ProductTwo":
                    return new ConcreteProductB();

                case "ProductThree":
                    return new ConcreteProductC();

                default:
                    throw new ArgumentException("Product does not exist");
            }
        }
    }
}
